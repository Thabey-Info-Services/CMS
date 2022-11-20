using CMS.Utility;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DAO
{
    public class DapperHandler
    {
        public static string CurrentConnectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        //FetchAll
        public static List<T> FetchAll<T>(string sSQL, object param = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(sSQL))
                {
                    using (SqlConnection con = new SqlConnection(CurrentConnectionString))
                    {
                        return con.Query<T>(sSQL, param, commandType: CommandType.Text).ToList();
                    }
                }
                else
                {
                    using (ErrorLog objlog = new ErrorLog())
                    {
                        objlog.WriteError("DapperHandler", "FetchAll<T>", sSQL, "Query is empty");
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                using (ErrorLog objlog = new ErrorLog())
                {
                    objlog.WriteError("DapperHandler", "FetchAll<T>", sSQL, ex.Message);
                }
                return null;
            }
        }
        //Update
        public static object SaveOrUpdate(string sSQL, object param = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(sSQL))
                {
                    using (SqlConnection con = new SqlConnection(CurrentConnectionString))
                    {
                        return con.Execute(sSQL, param, commandType: CommandType.Text);

                    }
                }
                else
                {
                    using (ErrorLog objlog = new ErrorLog())
                    {
                        objlog.WriteError("DapperHandler", "SaveOrUpdate", sSQL, "Query is empty");
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                using (ErrorLog objlog = new ErrorLog())
                {
                    objlog.WriteError("DapperHandler", "SaveOrUpdate", sSQL, ex.Message);
                }
                return null;
            }
        }
    }
}
