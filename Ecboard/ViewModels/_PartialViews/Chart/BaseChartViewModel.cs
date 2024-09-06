namespace Ecboard.ViewModels._PartialViews.Chart
{
    public class BaseChartViewModel
    {
        public string ChartType { get; set; }
        public List<string> Labels { get; set; }
        public string ChartId { get; set; }
        public List<string> Colors { get; set; }
    }
}
