using System;
using Azeroth.Nalu;

namespace Tenpower.Model
{
    public partial class DevDocKeywords
    {
        /// <summary>
        ///逻辑主键
        /// </summary>
        public Guid Id {set;get;}
        /// <summary>
        ///文档Id
        /// </summary>
        public Guid DocId {set;get;}
        /// <summary>
        ///关键字
        /// </summary>
        public String KeyWord {set;get;}
    }
}