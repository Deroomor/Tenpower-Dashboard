using System;
using Azeroth.Nalu;

namespace Tenpower.Model
{
    public partial class TreeSetInfo
    {
        /// <summary>
        ///自增长的主键
        /// </summary>
        public Guid Id {set;get;}
        /// <summary>
        ///当前节点
        /// </summary>
        public String Node {set;get;}
        /// <summary>
        ///父节点
        /// </summary>
        public String PNode {set;get;}
        /// <summary>
        ///默认使用的值
        /// </summary>
        [Azeroth.Nalu.XString(500,true)]
        public String Value {set;get;}
        /// <summary>
        ///数字类型的值
        /// </summary>
        public Nullable<Int32> ValueInt {set;get;}
        /// <summary>
        ///备用字符串的值
        /// </summary>
        [Azeroth.Nalu.XString(2000, true)]
        public String ValueStr {set;get;}
        /// <summary>
        ///节点的分组
        /// </summary>
        [Azeroth.Nalu.XStringMapEnum]
        public NodeIndex NodeIndexEnum {set;get;}
    }
}