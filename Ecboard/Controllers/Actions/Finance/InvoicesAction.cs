using Microsoft.AspNetCore.Mvc;

namespace Ecboard.Controllers.Actions.Finance
{
    public static class InvoicesAction
    {
        public static IActionResult AInvoices_Index(this Controller controller)
        {
            return controller.View();
        }

        public static IActionResult APrintInvoices(this Controller controller)
        {
            return controller.View();
        }
    }
}



