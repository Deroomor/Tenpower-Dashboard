using System;
using Azeroth.Nalu;

namespace Tenpower.Model
{
    public partial class DevDoc
    {
        /// <summary>
        ///逻辑主键
        /// </summary>
        public Guid Id {set;get;}
        /// <summary>
        ///文档的创建日期
        /// </summary>
        public DateTime DateInfo {set;get;}
        /// <summary>
        ///标题
        /// </summary>
        public String Title {set;get;}
        /// <summary>
        ///作者
        /// </summary>
        public String Author {set;get;}
        /// <summary>
        ///内容
        /// </summary>
        public String Value {set;get;}
    }
}