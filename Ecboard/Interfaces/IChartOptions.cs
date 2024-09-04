namespace Ecboard.ViewModel.Interface
{
    public interface IChartOptions
    {
        string ChartType { get; }
        List<int> Series { get; }
        List<string> Labels { get; }
        string ChartId { get; }
        List<string> Colors { get; }
    }
}
