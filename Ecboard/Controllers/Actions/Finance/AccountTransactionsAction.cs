using Microsoft.AspNetCore.Mvc;

namespace Ecboard.Controllers.Actions.Finance
{
    public static class AccountTransactionsAction
    {
        public static IActionResult AAccountTransactions_Index(this Controller controller)
        {
            return controller.View();
        }
    }
}