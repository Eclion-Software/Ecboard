using Ecboard.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

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
        public string CardTitle { get; set; }
        public string CardSubtitle { get; set; }
        public string CardDescription { get; set; }
        public string CardColor { get; set; } = "primary";
        public string CardHeaderClass { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            (_htmlHelper as IViewContextAware)?.Contextualize(ViewContext);

            // Modeli doldur
            var cardModel = new CardViewModel
            {
                CardType = CardType,
                CardTitle = CardTitle,
                CardSubtitle = CardSubtitle,
                CardDescription = CardDescription,
                CardColor = CardColor,
                CardHeaderClass = CardHeaderClass
            };

            var partialViewHtml = await _htmlHelper.PartialAsync("~/Views/Shared/_PartialViews/_pCard.cshtml", cardModel);

            output.TagName = "card";
            output.Content.SetHtmlContent(partialViewHtml);
        }
    }
}
