using System.Collections.Generic;

namespace Ecboard.ViewModel.Interface
{
    public class ChartOptions : IChartOptions
    {
        public string ChartType { get; set; }
        public List<int> Series { get; set; }
        public List<string> Labels { get; set; }
        public string ChartId { get; set; }
        public List<string> Colors { get; set; }


    }
}
