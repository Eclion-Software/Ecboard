using System.Collections.Generic;
using Ecboard.Interfaces.Chart;

namespace Ecboard.ViewModel.Interface
{
    public class ChartOptions : IChartOptions
    {
        public string ChartType { get; set; }
        public List<ChartSeries> Series { get; set; }
        public List<string> Labels { get; set; }
        public string ChartId { get; set; }
        public List<string> Colors { get; set; }
    }
}
