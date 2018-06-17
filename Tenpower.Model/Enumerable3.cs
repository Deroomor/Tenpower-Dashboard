using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Linq
{
    public  static class Enumerable3
    {
        public static void AutoMap<T, B>(this T old, B target)where B :class where T:class
        {
            var dictT = Azeroth.OMT.DbSet<T>.GetDictMapHandler();
            var dictB = Azeroth.OMT.DbSet<B>.GetDictMapHandler();
            foreach (var kv in dictB)
            {
                if (!dictT.Keys.Contains(kv.Key))
                    continue;
                kv.Value.SetValueToInstance(target, dictT[kv.Key].GetValueFromInstance(old, null), null);
            }
        }
    }
}
