using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tenpower.UI
{
    public partial class Default : System.Web.UI.Page
    {
        static string urlDefault = System.Configuration.ConfigurationManager.AppSettings["url:default"];
        protected override void OnInit(EventArgs e)
        {
            this.Response.Redirect(urlDefault);
        }
    }
}