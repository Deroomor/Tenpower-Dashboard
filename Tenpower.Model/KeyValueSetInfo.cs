using System;
using Azeroth.Nalu;

namespace Tenpower.Model
{
    public partial class KeyValueSetInfo
    {
        /// <summary>
        ///逻辑主键
        /// </summary>
        public Guid Id {set;get;}
        /// <summary>
        ///记录创建日期
        /// </summary>
        public DateTime CreateDateTimeInfo {set;get;}
        /// <summary>
        ///
        /// </summary>
        public String Key {set;get;}
        /// <summary>
        ///默认使用的值
        /// </summary>
        [XString(500,true)]
        public String Value {set;get;}
        /// <summary>
        ///数字类型的值
        /// </summary>
        public Nullable<Int32> ValueInt {set;get;}
        /// <summary>
        ///字符串类型的值
        /// </summary>
        [XString(1000,true)]
        public String ValueStr {set;get;}
        /// <summary>
        ///键的分组
        /// </summary>
        [Azeroth.Nalu.XStringMapEnum]
        public KeyIndex KeyIndexEnum {set;get;}
    }
}