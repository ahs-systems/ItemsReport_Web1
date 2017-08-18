using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ItemsReport_Web.ViewModels;
using System.Web.Security;
using ItemsReport_Web.Models;

namespace ItemsReport_Web.Controllers
{
    
    public class NppController : Controller
    {
        // GET: Npp
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
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