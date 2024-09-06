using Microsoft.AspNetCore.Mvc;
using Ecboard.Services;
using Ecboard.ViewModels._PartialViews.Chart;

namespace Ecboard.ViewComponents
{
    public class ChartViewComponent : ViewComponent
    {
        private readonly ChartOptionsService _chartOptionsService;

        public ChartViewComponent(ChartOptionsService chartOptionsService)
        {
            _chartOptionsService = chartOptionsService;
        }

        public async Task<IViewComponentResult> InvokeAsync(BaseChartViewModel model)
        {
            var chartData = _chartOptionsService.GetChartOptions(model);

            return View("_pCharts", chartData);
        }
    }
}
