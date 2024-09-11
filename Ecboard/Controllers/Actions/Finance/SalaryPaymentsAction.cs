using Microsoft.AspNetCore.Mvc;

namespace Ecboard.Controllers.Actions.Finance
{
    public static class SalaryPaymentsAction
    {
        public static IActionResult ASalaryPayments_Index(this Controller controller)
        {
            return controller.View();
        }
    }
}

