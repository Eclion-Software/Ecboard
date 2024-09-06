using Microsoft.AspNetCore.Mvc;
using Ecboard.Services;
using Ecboard.ViewModel.Interface;
using Ecboard.ViewModels;
using Ecboard.Enum;

namespace Ecboard.ViewComponents
{
    public class AlertViewComponent : ViewComponent
    {
        //public async Task<IViewComponentResult> InvokeAsync(AlertViewModel model)
        //{

        //    return View("_pAlert", model);
        //}

        public async Task<IViewComponentResult> InvokeAsync(string name, Enum_Color color)
        {

            return View("_pAlert", new AlertViewModel()
            {
                AlertType = Enum.Enum_AlertType.Default,
                Color = color,
                Description = "",
                Name = name
            });
        }

        //public async Task<IViewComponentResult> InvokeAsync(string name)
        //{

        //    return View("_pAlert", new AlertViewModel()
        //    {
        //        AlertType = Enum.Enum_AlertType.Default,
        //        Color = Enum.Enum_Color.secondary,
        //        Description = "",
        //        Name = name
        //    });
        //}
    }
}
