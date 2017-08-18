using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ItemsReport_Web1.ViewModels;
using System.Web.Security;

namespace ItemsReport_Web1.Controllers
{
    
    public class NppController : Controller
    {
        private SystemDBContext _context;

        public NppController()
        {
            _context = new SystemDBContext();
        }

        // GET: Npp
        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Index()
        {
            var itemsReportLetter = _context.ItemsReportLetters.ToList();
            var status = _context.Status.ToList();
            var payPeriods = _context.PayPeriods.ToList();

            Models.Common _common = new Models.Common();

            var viewModel = new NppFormViewModel
            {
                NewPrimaryPosition = new NewPrimaryPosition(),
                List_ItemsReportLetter = itemsReportLetter,
                List_PayPeriod = payPeriods,
                List_Status = status,
                List_PayPeriodYear = _common.GetYearList()
            };

           
            

            return View(viewModel);
        }        
    }
}