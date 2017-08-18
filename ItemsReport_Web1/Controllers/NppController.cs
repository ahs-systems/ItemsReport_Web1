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
        // GET: Npp
        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Index()
        {
            Models.Common _common = new Models.Common();

            var model = new NppFormViewModel();

            model.List_ItemsReportLetter = _common.GetItemsReportLetterList();
            model.List_Status = _common.GetStatusList();
            model.List_PayPeriod = _common.GetPayPeriodList();
            model.List_PayPeriodYear = _common.GetYearList();
            model.NewPrimaryPosition = new NewPrimaryPosition();
            model.NewPrimaryPosition.EnteredBy = User.Identity.Name;
            

            return View(model);
        }        
    }
}