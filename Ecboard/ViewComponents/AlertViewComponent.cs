using Microsoft.AspNetCore.Mvc;
using Ecboard.Services;
using Ecboard.ViewModels;
using Ecboard.Enum;

namespace Ecboard.ViewComponents
{
    public class AlertViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(object _model, Enum_Color? color)
        {
            if (_model is AlertViewModel model)
            {
                return View("_pAlert", model);
            }
            else if (_model is string name)
            {
                var alertViewModel = new AlertViewModel()
                {
                    AlertType = Enum.Enum_AlertType.Default,
                    Color = color ?? Enum.Enum_Color.secondary,
                    Description = "",
                    Name = name
                };
                return View("_pAlert", alertViewModel);
            }

            throw new ArgumentException("Invalid parameters provided.");
        }
    }
}
