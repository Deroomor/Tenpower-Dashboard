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
            System.Web.Routing.RouteTable.Routes.Add(new System.Web.Routing.Route("{nav}/{controller}/{action}", new Azeroth.Klz.RouteHandler()));
            System.Web.Routing.RouteTable.Routes.Add(new System.Web.Routing.Route("{nav}/{section}/{controller}/{action}", new Azeroth.Klz.RouteHandler()));

            //处理依赖注入
            System.ComponentModel.Composition.Hosting.DirectoryCatalog catalog = new System.ComponentModel.Composition.Hosting.DirectoryCatalog(System.Web.HttpRuntime.BinDirectory);
            //System.ComponentModel.Composition.Hosting.CompositionContainer container = new System.ComponentModel.Composition.Hosting.CompositionContainer(catalog);
            System.AppDomain.CurrentDomain.SetData("__@@catalog", catalog);
         
        }

        public override void Init()
        {
            this.BeginRequest += Global_BeginRequest;
        }

        void Global_BeginRequest(object sender, EventArgs e)
        {
            string tmp = this.Request.Url.AbsolutePath.ToLower();
            if (tmp.EndsWith(".cshtml"))
                this.Response.Redirect(tmp.Substring(0, tmp.Length - 7));
            //if (tmp.EndsWith(".aspx"))
            //    this.Response.Redirect(tmp.Substring(0, tmp.Length - 5));
        }
       
    }
}