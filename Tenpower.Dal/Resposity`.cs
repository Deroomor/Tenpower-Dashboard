using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tenpower.Dal
{
    public class Resposity<T> : Resposity,IDal.IResposity<T>
    {
        public Azeroth.OMT.SaveChangeResult Add(params T[] value)
        {
            var dbset = this.DbContext.DbSet<T>();
            dbset.Select();
            dbset.Add(value);
            return dbset.SaveChange();
        }

        public List<T> GetEntity<S>(System.Linq.Expressions.Expression<Func<T, S>> sl, Azeroth.OMT.WH opt, params S[] parameterValue)
        {
            var dbset = this.DbContext.DbSet<T>();
            dbset.Select();
            dbset.Where(sl,opt,parameterValue);
            var lst = dbset.ToList();
            return lst;
        }

        public M Cast<M>() where M:IDal.IResposity<T>
        {
            return (M)(object)this;
        }

        Azeroth.OMT.SaveChangeResult IDal.IResposity<T>.Add(params T[] value)
        {
            return this.Add(value);
        }

        List<T> IDal.IResposity<T>.GetEntity<S>(System.Linq.Expressions.Expression<Func<T, S>> sl, Azeroth.OMT.WH opt, params S[] parameterValue)
        {
            return this.GetEntity(sl,opt,parameterValue);
        }


        List<T> IDal.IResposity<T>.GetEntity()
        {
            return this.GetEntity();
        }

        public List<T> GetEntity()
        {
            var dbset = this.DbContext.DbSet<T>();
            dbset.Select();
            var lst = dbset.ToList();
            return lst;
        }
    }
}
