﻿using ItemsReport_Web1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItemsReport_Web1.ViewModels
{
    public class NppFormViewModel
    {
        public NewPrimaryPosition NewPrimaryPosition { get; set; }
        public IEnumerable<ItemsReportLetter> List_ItemsReportLetter { get; set; }
        public IEnumerable<PayPeriod> List_PayPeriod { get; set; }        
        public IEnumerable<Status> List_Status { get; set; }
        public IEnumerable<SelectListItem> List_PayPeriodYear { get; set; }
    }
}