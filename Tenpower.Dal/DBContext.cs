using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tenpower.Dal
{
    [System.ComponentModel.Composition.Export(typeof(IDal.IDbContext))]
    public class DbContext:Azeroth.Nalu.DbContext<System.Data.SqlClient.SqlConnection>,IDal.IDbContext
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


        public override Azeroth.Nalu.ResovleContext GetResolvContext()
        {
            return new Azeroth.Nalu.ResovleContext(Leadchar,()=>new System.Data.SqlClient.SqlParameter());
        }

        public DbContext()
        {
            this.Cnnstr = MSSQLMaster;
        }
    }
}
