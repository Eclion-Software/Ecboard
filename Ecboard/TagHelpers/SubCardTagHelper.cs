using Ecboard.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Ecboard.Enums;
using System.Threading.Tasks;

namespace Ecboard.TagHelpers
{
    [HtmlTargetElement("sub-card")]
    public class SubCardTagHelper : TagHelper
    {
        private readonly IHtmlHelper _htmlHelper;

        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public SubCardTagHelper(IHtmlHelper htmlHelper)
        {
            _htmlHelper = htmlHelper;
        }

        public string Title { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public Enum_Color BackgroundColor { get; set; } 

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            (_htmlHelper as IViewContextAware)?.Contextualize(ViewContext);

            var model = new SubCardViewModel
            {
                Title = Title,
                Value = Value,
                Description = Description,
                Icon = Icon,
                BackgroundColor = BackgroundColor.ToString().ToLower() 
            };

            var content = await _htmlHelper.PartialAsync("_PartialViews/_pSubCard", model);
            output.Content.SetHtmlContent(content);
        }
    }
}
