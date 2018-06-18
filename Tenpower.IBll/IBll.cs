using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tenpower.IBll
{
    public interface IBll
    {
        IDal.IDbContext DbContext { set; get; }
    }
}
