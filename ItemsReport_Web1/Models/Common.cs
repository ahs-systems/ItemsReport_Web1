using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItemsReport_Web1.Models
{

    public class Common
    {
        private IEnumerable<string> GetItemsReportLetter()
        {
            return new List<string>
            {
                "Items Report A",
                "Items Report B",
                "Items Report C"
            };
        }

        private IEnumerable<string> GetStatus()
        {
            return new List<string>
            {
                "RFT", "TFT", "RPT", "TPT", "CAS"
            };
        }

        private IEnumerable<string> GetPayPeriodYear()
        {
            return new List<string>
            {
                (DateTime.Today.Year).ToString(),
                (DateTime.Today.Year-1).ToString(),
            };            
        }

        private IEnumerable<string> GetPayPeriod()
        {
            List<string> _ret = new List<string>();

            for (int i = 1; i <= 26; i++)
            {
                _ret.Add(i.ToString());
            }

            return _ret;
        }

        public IEnumerable<SelectListItem> GetStatusList()
        {
            return GetSelectListItems(GetStatus());
        }

        public IEnumerable<SelectListItem> GetItemsReportLetterList()
        {
            return GetSelectListItems(GetItemsReportLetter());
        }

        public IEnumerable<SelectListItem> GetYearList()
        {
            return GetSelectListItems(GetPayPeriodYear());
        }

        public IEnumerable<SelectListItem> GetPayPeriodList()
        {
            return GetSelectListItems(GetPayPeriod());
        }

        private IEnumerable<SelectListItem> GetSelectListItems(IEnumerable<string> elements)
        {
            // Create an empty list to hold result of the operation
            var selectList = new List<SelectListItem>();

            // For each string in the 'elements' variable, create a new SelectListItem object
            // that has both its Value and Text properties set to a particular value.
            // This will result in MVC rendering each item as:
            //     <option value="State Name">State Name</option>
            foreach (var element in elements)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element,
                    Text = element
                    // Selected = (element == "CAS")
                });
            }

            return selectList;
        }
    }
}