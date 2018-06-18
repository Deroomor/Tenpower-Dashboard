using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tenpower.UI.Barometer.M2
{
    public class Quality:NavController
    {

        public Azeroth.Klz.ActionResult BMP()
        {
            string monthKey = "month";
            var tmp = this.Context.Request[monthKey];
            DateTime tmpDT;
            if (!DateTime.TryParse(tmp, out tmpDT))
                tmpDT = DateTime.Now.AddMonths(-1);
            this.ViewData[monthKey] = tmpDT;
            return View();
        }
    }
}