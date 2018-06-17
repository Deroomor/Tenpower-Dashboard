using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tenpower.W3.Barometer.M1
{
    public class M1:NavController
    {
        public override Azeroth.MVC.ActionResult Invoke(Delegate method)
        {
            return ((Func<M1, Azeroth.MVC.ActionResult>)method)(this);
        }

        public Azeroth.MVC.ActionResult CPQuality()
        {
            string monthKey = "month";
            var tmp = this.Context.Request[monthKey];
            DateTime tmpDT;
            if (!DateTime.TryParse(tmp, out tmpDT))
                tmpDT = DateTime.Now.AddMonths(-1);
            this.ViewData[monthKey] = tmpDT;
            return View();
        }

        public Azeroth.MVC.ActionResult BMPQuality()
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