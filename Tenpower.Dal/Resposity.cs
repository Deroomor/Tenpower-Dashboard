using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tenpower.Dal
{
    public class Resposity
    {
        protected DbContext DbContext { private set; get; }

        public Resposity()
        {
            this.DbContext = new DbContext();
            this.DbContext.Cnnstr = Dal.DbContext.MSSQLMaster;
        }
    }
}
