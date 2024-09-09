using Ecboard.Enums;
using Ecboard.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Drawing;

namespace Ecboard.TagHelpers
{
    public class CardTagHelper : TagHelper
    {
        private readonly IHtmlHelper _htmlHelper;

        public CardTagHelper(IHtmlHelper htmlHelper)
        {
            _htmlHelper = htmlHelper;
        }

        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public string CardType { get; set; }
        public string? Title { get; set; }
        public string? Subtitle { get; set; }
        public string? Description { get; set; }
        public string? Footer { get; set; }
        public string? Color { get; set; } = "primary";
        public string? Image { get; set; }
        public string? Icon { get; set; }
        public string? Link { get; set; }
        public string? ButtonText { get; set; } = "Learn more";
        public int? Progress { get; set; }
        public string? Direction { get; set; } = "top";

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            (_htmlHelper as IViewContextAware)?.Contextualize(ViewContext);

            var cardModel = new CardViewModel
            {
                CardType = System.Enum.Parse<Enum_CardType>(CardType.ToLower()),
                Title = Title,
                Subtitle = Subtitle,
                Description = Description,
                Footer = Footer,
                Color = System.Enum.Parse<Enum_Color>(Color.ToLower()),                
                Image = Image,
                Icon = Icon,
                Link = Link,
                ButtonText = ButtonText,
                Progress = Progress,
                Direction = System.Enum.Parse<Enum_Direction>(Direction.ToLower())
            };

            var partialViewHtml = await _htmlHelper.PartialAsync("~/Views/Shared/_PartialViews/_pCard.cshtml", cardModel);

            output.TagName = "card";
            output.Content.SetHtmlContent(partialViewHtml);
        }
    }
}
