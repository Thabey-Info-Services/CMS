using CMS.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.SQL
{
   public class AccontSQL
    {
        public static string GetAccountSQL(AccountSQLCommand sEnumCommand)
        {
            string query = string.Empty;
            switch (sEnumCommand)
            {

                case AccountSQLCommand.FetchLogindetails:
                    {
                        query = @"SELECT 
                                        UA.USER_ACCOUNT_ID,
                                        UA.USERNAME,
                                        SR.ROLE_NAME,
                                        UA.ROLE,
                                        SU.USER_TYPE_NAME,
                                        SU.USER_TYPE_ID,
                                        UA.USER_ID,
                                        UA.NAME,
                                        UA.PHOTO,CONTROLLER_NAME,ACTION_NAME
                                    FROM
                                        USER_ACCOUNT AS UA
                                            LEFT JOIN
                                        SUP_ROLE AS SR ON SR.ROLE_ID = UA.ROLE
                                            LEFT JOIN
                                        SUP_USER_TYPE AS SU ON SU.USER_TYPE_ID = UA.USER_TYPE
                                    WHERE
                                        UA.USERNAME = @USERNAME
                                            AND UA.PASSWORD = HASHBYTES('SHA2_256','@PASSWORD') AND UA.IS_DELETED!=1;";
                        break;
                    }
            }
            return query;
        }
    }
}
