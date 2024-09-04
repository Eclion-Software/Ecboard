using System.Collections.Generic;
using Ecboard.ViewModel.Interface;

namespace Ecboard.Services
{
    public class ChartOptionsService
    {
        public IChartOptions GetChartOptions(string chartType)
        {
            if (chartType == "pie")
            {
                return new ChartOptions
                {
                    ChartType = "pie",
                    Series = new List<int> { 44, 55, 13, 33 },
                    Labels = new List<string> { "Direct", "Affiliate", "E-mail", "Other" },
                    ChartId = "chart1",
                    Colors = new List<string> { "#FF5733", "#33FF57", "#3357FF", "#FF33A1" }
                };
            }


            else if (chartType == "bar")
            {
                return new ChartOptions
                {
                    ChartType = "bar",
                    Series = new List<int> { 23, 45, 67, 12 },
                    Labels = new List<string> { "Jan", "Feb", "Mar", "Apr" },
                    ChartId = "chart2",
                    Colors = new List<string> { "#FF5733" }
                };


            }

            return null;
        }
    }
}
