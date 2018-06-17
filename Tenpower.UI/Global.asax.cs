using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;

namespace Tenpower.UI
{
    public class Global : System.Web.HttpApplication
    {
       
        public void Application_Start()
        {
            System.Web.Routing.RouteTable.Routes.Add(new System.Web.Routing.Route("{nav}/{controller}/{action}", new Azeroth.MVC.RouteHandler()));
            System.Web.Routing.RouteTable.Routes.Add(new System.Web.Routing.Route("{nav}/{section}/{controller}/{action}", new Azeroth.MVC.RouteHandler()));
        }
       
    }
}