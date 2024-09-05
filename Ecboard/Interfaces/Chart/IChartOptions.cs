namespace Ecboard.Interfaces.Chart
{
    public interface IChartOptions
    {
        string ChartType { get; set; }
        List<ChartSeries> Series { get; set; }
        List<string> Labels { get; set; }
        string ChartId { get; set; }
        List<string> Colors { get; set; }
    }
}
