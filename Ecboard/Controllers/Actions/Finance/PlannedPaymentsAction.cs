 using Microsoft.AspNetCore.Mvc;

namespace Ecboard.Controllers.Actions.Finance
{
    public static class PlannedPaymentsAction
    {
        public static IActionResult APlannedPaymentsIndex(this Controller controller)
        {
            return controller.View();
        }
    }
}