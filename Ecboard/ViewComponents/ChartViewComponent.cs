using Microsoft.AspNetCore.Mvc;
using Ecboard.Services;
using Ecboard.ViewModel.Interface;

namespace Ecboard.ViewComponents
{
    public class ChartViewComponent : ViewComponent
    {
        private readonly ChartOptionsService _chartOptionsService;

        public ChartViewComponent(ChartOptionsService chartOptionsService)
        {
            _chartOptionsService = chartOptionsService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string chartType)
        {
            var chartData = _chartOptionsService.GetChartOptions(chartType);

            return View("_pCharts", chartData);
        }
    }
}
