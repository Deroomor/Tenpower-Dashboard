using Azeroth.Nalu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tenpower.IDal
{
    public interface IDbContext
    {
        Result ExecuteNoQuery(params ICud[] lstcud);
        //List<T> ExecuteQuery<T>(IDbSetContainer query, Func<object[], T> transfer);
        //ResovleContext GetResolvContext();
        DbCud<T> NoQuery<T>();
        DbSetContainer Query();
    }
}
