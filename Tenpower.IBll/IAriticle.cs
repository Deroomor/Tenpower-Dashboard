using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tenpower.IBll
{
    public interface IAriticle:IBll
    {
        Model.DevDoc GetEntityById(Guid guid);

        void Save(Model.DevDoc parameter);

        List<Model.DevDoc> GetEntity();
    }
}
