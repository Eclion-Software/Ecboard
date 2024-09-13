using Microsoft.AspNetCore.Html;

namespace Ecboard.ViewModels
{
    public class SubCardWithChartViewModel
    {
        public string Title { get; set; }
        public string DropdownText { get; set; }
        public string ChartId { get; set; }
        public string Amount { get; set; }
        public string PercentageChange { get; set; }
        public IHtmlContent DropdownItems { get; set; }
    }
}
