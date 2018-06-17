using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
namespace Tenpower.IDal
{
    public interface IResposity<T>
    {
        Azeroth.OMT.SaveChangeResult Add(params T[] value);
        List<T> GetEntity();
        List<T> GetEntity<S>(Expression<Func<T, S>> sl, Azeroth.OMT.WH opt, params S[] parameterValue);
    }
}
