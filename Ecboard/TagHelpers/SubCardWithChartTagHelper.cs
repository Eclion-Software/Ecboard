using Ecboard.Enums;
using Ecboard.ViewModels;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Drawing;

namespace Ecboard.TagHelpers;

[HtmlTargetElement("sub-card-with-chart")]
public class SubCardWithChartTagHelper : TagHelper
{
    private readonly IHtmlHelper _htmlHelper;

    public SubCardWithChartTagHelper(IHtmlHelper htmlHelper)
    {
        _htmlHelper = htmlHelper;
    }

    [ViewContext]
    [HtmlAttributeNotBound]
    public ViewContext ViewContext { get; set; }

    public string Title { get; set; }
    public string DropdownText { get; set; }
    public string ChartId { get; set; }
    public string Amount { get; set; }
    public string PercentageChange { get; set; }

    [HtmlAttributeName("dropdown-items")]
    public IHtmlContent DropdownItems { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        // ViewContext'i IHtmlHelper ile bağdaştır
        ((IViewContextAware)_htmlHelper).Contextualize(ViewContext);

        // ViewModel oluştur
        var viewModel = new SubCardWithChartViewModel
        {
            Title = Title,
            DropdownText = DropdownText,
            ChartId = ChartId,
            Amount = Amount,
            PercentageChange = PercentageChange,
            DropdownItems = DropdownItems
        };

        // Partial View'i render et
        var partialViewResult = await _htmlHelper.PartialAsync(
            "~/Views/Shared/_PartialViews/_pSubCardWithChart.cshtml", viewModel);

        // Render edilen içeriği output'a aktar
        output.Content.SetHtmlContent(partialViewResult);
    }
}
