using Ecboard.Controllers.Actions.Finance;
using Ecboard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ecboard.Controllers
{
    public class FinanceController : Controller
    {

        private readonly ILogger<FinanceController> _logger;

        public FinanceController(ILogger<FinanceController> logger)
        {
            _logger = logger;
        }


        //Main Actions
        public IActionResult PlannedPayments_Index()
        {
            return this.APlannedPaymentsIndex();
        }


        public IActionResult AccountTransactions_Index()
        {
            return this.AAccountTransactions_Index();
        }


        //Invoice Actions
        public IActionResult Invoice_Index()
        {
            return this.AInvoices_Index();
        }


        public IActionResult Print_Invoice()
        {
            return this.APrintInvoices();
        }

        //Invoice Actions


        public IActionResult SalaryPayments_Index()
        {
            return this.ASalaryPayments_Index();
        }
        //Main Actions



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
