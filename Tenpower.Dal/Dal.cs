using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tenpower.Dal
{
    public class Dal
    {
        public DbContext DbContex {private set; get; }

        public Dal()
        {
            this.DbContex = new DbContext();
        }
    }
}
