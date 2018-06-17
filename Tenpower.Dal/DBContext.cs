using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tenpower.Dal
{
    public class DbContext:Azeroth.OMT.DbContext<System.Data.SqlClient.SqlConnection>
    {
        /// <summary>
        /// key=mssqlmaster的数据库连接配置
        /// </summary>
        public static readonly string MSSQLMaster =
            System.Configuration.ConfigurationManager.ConnectionStrings["mssqlmaster"].ConnectionString;

        ///// <summary>
        ///// key=mssqlslaver的数据库连接配置
        ///// </summary>
        //public static readonly string MSSQLSlaver =
        //    System.Configuration.ConfigurationManager.ConnectionStrings["mssqlslaver"].ConnectionString;

        ///// <summary>
        ///// key=oraclemaster的数据库连接配置
        ///// </summary>
        //public static readonly string OracleMaster =
        //    System.Configuration.ConfigurationManager.ConnectionStrings["oraclemaster"].ConnectionString;

        ///// <summary>
        ///// key=oracleslaver的数据库连接配置
        ///// </summary>
        //public static readonly string OracleSlaver =
        //    System.Configuration.ConfigurationManager.ConnectionStrings["oracleslaver"].ConnectionString;

        const string Leadchar = "@";

        static Func<System.Data.Common.DbParameter> handler = () => new System.Data.SqlClient.SqlParameter();

        protected override Azeroth.OMT.ResolverContext GetResolverContext(System.Data.Common.DbCommand cmd)
        {
            return new Azeroth.OMT.ResolverContext(Leadchar,handler);
        }
    }
}
