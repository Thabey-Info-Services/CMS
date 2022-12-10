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
	                                COUNT(*) AS COUNT
                                FROM 
	                                LOGIN_MASTER 
                                WHERE 
	                                MOBILE_NO = @MOBILE_NO;";
                        break;
                    }
                case AccountSQLCommand.SaveNewUser:
                    {
                        query = @"INSERT INTO REGISTRATION
	                                    (FIRST_NAME,LAST_NAME,EMAIL,MOBILE_NO,IS_LOCKED,USER_ROLE)
                                  VALUES
	                                    (@FIRST_NAME,@LAST_NAME,@EMAIL,@MOBILE_NO,0,1);";
                        break;
                    }
                case AccountSQLCommand.FetchRequirement:
                    {
                        query = @"SELECT 
	                                 [REQUIREMENT_ID]
	                                ,[REQUIREMENT_NAME] 
                                  FROM
	                                 SUB_REQUIREMENT 
                                 WHERE 
	                                IS_LOCKED != 1;";
                        break;
                    }
            }
            return query;
        }
    }
}
