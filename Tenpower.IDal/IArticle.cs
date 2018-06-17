using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tenpower.IDal
{
    public interface IDevDoc:IResposity<Model.DevDoc>
    {
      void  Save(Model.DevDoc doc);
      void Edit(Model.DevDoc doc);
    }
}
