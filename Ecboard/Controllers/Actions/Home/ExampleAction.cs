 using Microsoft.AspNetCore.Mvc;

namespace Ecboard.Controllers.Actions.Home
{
    public static class ExampleAction
    {
        public static IActionResult CustomAction(this Controller controller, int id)
        {
            return controller.View(id);
        }
    }
}