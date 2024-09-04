using Microsoft.AspNetCore.Mvc;
using Ecboard.Services;
using Ecboard.ViewModel.Interface;
using Ecboard.ViewModels;

namespace Ecboard.ViewComponents
{
    public class AlertViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(AlertViewModel model)
        {

            return View("_pAlert", model);
        }
    }
}
