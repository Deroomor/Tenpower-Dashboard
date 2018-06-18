using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
namespace Tenpower.Bll
{
    public class Bll:IBll.IBll
    {
        static System.ComponentModel.Composition.Hosting.CompositionContainer container =
           new System.ComponentModel.Composition.Hosting.CompositionContainer(System.AppDomain.CurrentDomain.GetData("__@@catalog") as System.ComponentModel.Composition.Hosting.DirectoryCatalog);
        
        [System.ComponentModel.Composition.Import(typeof(IDal.IDbContext))]
        public IDal.IDbContext DbContext { set; get; }

        public Bll()
        { //执行注入
           
            container.ComposeParts(this);
        }
    }
}
