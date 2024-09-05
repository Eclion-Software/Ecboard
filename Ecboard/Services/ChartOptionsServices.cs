using System.Collections.Generic;
using Ecboard.Interfaces.Chart;
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
                    Series = new List<ChartSeries>
                    {
                        new ChartSeries
                        {
                            Data = new List<int> { 44, 55, 13, 33 }
                        }
                    },
                    Labels = new List<string> { "Direct", "Affilliate", "E-mail", "Other" },
                    ChartId = "chart1",
                    Colors = new List<string> { "#FF5733", "#33FF57", "#3357FF", "#FF33A1" }
                };
            }
            else if (chartType == "bar")
            {
                return new ChartOptions
                {
                    ChartType = "bar",
                    Series = new List<ChartSeries>
                    {
                        new ChartSeries
                        {
                            Name = "Sales",
                            Data = new List<int> { 23, 45, 67, 12 }
                        }
                    },
                    Labels = new List<string> { "Jan", "Feb", "Mar", "Apr" },
                    ChartId = "chart2",
                    Colors = new List<string> { "#FF5733", "#FFC300", "#DAF7A6", "#C70039" }
                };
            }
            else if (chartType == "line")
            {
                return new ChartOptions
                {
                    ChartType = "line",
                    Series = new List<ChartSeries>
                    {
                        new ChartSeries
                        {
                            Name = "Sales",
                            Data = new List<int> { 10, 41, 35, 51, 49, 62, 69, 91, 148 }
                        }
                    },
                    Labels = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep" },
                    ChartId = "chart3",
                    Colors = new List<string> { "#008FFB" }
                };
            }
            else if (chartType == "area")
            {
                return new ChartOptions
                {
                    ChartType = "area",
                    Series = new List<ChartSeries>
                    {
                        new ChartSeries
                        {
                            Name = "Revenue",
                            Data = new List<int> { 31, 40, 28, 51, 42, 109, 100 }
                        }
                    },
                    Labels = new List<string> { "2011", "2012", "2013", "2014", "2015", "2016", "2017" },
                    ChartId = "chart4",
                    Colors = new List<string> { "#00E396" }
                };
            }

            return null;
        }
    }
}
