using System.Collections.Generic;
using Ecboard.ViewModels._PartialViews.Chart;

namespace Ecboard.Services
{
    public class ChartOptionsService
    {
        public BaseChartViewModel GetChartOptions(BaseChartViewModel model)
        {
            if (model.ChartType == "pie")
            {
                PieChartViewModel _model = new PieChartViewModel()
                {
                    ChartId = model.ChartId,
                    ChartType = model.ChartType,
                    Colors = model.Colors,
                    Labels = model.Labels,
                    Series = (model as PieChartViewModel).Series
                };
                return _model;
            }
            else
            {
                DefaultChartViewModel _model = new DefaultChartViewModel()
                {
                    ChartId = model.ChartId,
                    ChartType = model.ChartType,
                    Colors = model.Colors,
                    Labels = model.Labels,
                    Series = (model as DefaultChartViewModel).Series
                };
                return _model;
            }
        }
    }
}
