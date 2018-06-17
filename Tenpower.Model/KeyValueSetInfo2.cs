using System;
using Azeroth.OMT;

namespace Tenpower.Model
{
    public partial class KeyValueSetInfo
    {
        public enum KeyIndex
        {
            BMPCode=1,//二次电源的BMP的编码集合
            POLCode,
            PSIP,
            Adapter,
        }
    }
}