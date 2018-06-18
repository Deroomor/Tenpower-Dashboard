using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tenpower.Bll
{
    [System.ComponentModel.Composition.Export(typeof(IBll.IAriticle))]
    public class Ariticle : Bll,IBll.IAriticle
    {

        public Model.DevDoc GetEntityById(Guid guid)
        {
            var query= this.DbContext.Query();
            var tbdoc= query.Set<Model.DevDoc>();
            query.Select(tbdoc.Cols());
            query.WH = tbdoc.Col(x => x.Id) == guid;
            var lst= query.ToList<Model.DevDoc>();
            return lst.FirstOrDefault();
        }

        public void Save(Model.DevDoc parameter)
        {
            throw new NotImplementedException();
        }

        public List<Model.DevDoc> GetEntity()
        {
            var query = this.DbContext.Query();
            var tbdoc = query.Set<Model.DevDoc>();
            query.Select(tbdoc.Cols());
            var lst = query.ToList<Model.DevDoc>();
            return lst;
        }
    }
}
