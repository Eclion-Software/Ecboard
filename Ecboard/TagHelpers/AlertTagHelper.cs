using Ecboard.Enums;
using Ecboard.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.VisualBasic;

namespace Ecboard.TagHelpers
{
    public class AlertTagHelper : TagHelper
    {
        private readonly IHtmlHelper _htmlHelper;

        public AlertTagHelper(IHtmlHelper htmlHelper)
        {
            _htmlHelper = htmlHelper;
        }

        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public string? AlertType { get; set; } = "_default";
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Color { get; set; } = "primary";

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            (_htmlHelper as IViewContextAware)?.Contextualize(ViewContext);

            var alertModel = new AlertViewModel
            {
                AlertType = System.Enum.Parse<Enum_AlertType>(AlertType.ToLower()),
                Name = Name,
                Description = Description,
                Color = System.Enum.Parse<Enum_Color>(Color.ToLower())
            };

            var partialViewHtml = await _htmlHelper.PartialAsync("~/Views/Shared/_PartialViews/_pAlert.cshtml", alertModel);

            output.TagName = "alert";
            output.Content.SetHtmlContent(partialViewHtml);
        }
    }
}
