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
                        query = @"SELECT distinct
                                    UA.[USER_ID],
                                    UA.USER_TYPE
                                FROM 
	                                USER_ACCOUNT UA
                                INNER JOIN 
	                                REGISTRATION R ON R.ID = UA.[USER_ID]
                                WHERE 
	                                USERNAME=@USERNAME 
                                 AND 
	                                [PASSWORD]=@PASSWORD
                                 AND 
	                                [IS_DELETED] = 0 
                                 AND 
	                                [IS_ACTIVE] = 1";
                        break;
                    }
                case AccountSQLCommand.FetchUserdetails:
                    {
                        query = @"SELECT 
                                   ISNULL(USERNAME,'0') as [USER_NAME]
                                FROM 
	                                USER_ACCOUNT UA
                                INNER JOIN 
	                                REGISTRATION R ON R.ID = UA.[USER_ID]
                                WHERE 
	                                USERNAME=@USERNAME";
                        break;
                    }
                case AccountSQLCommand.SaveNewUser:
                    {
                        query = @"EXEC USP_SAVEUSER_DETAILS @FIRST_NAME ,@LAST_NAME,@EMAIL,@REQUIREMENT,@PASSWORD,@CONFIRM_PASSWORD";
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
                case AccountSQLCommand.FetchUserProfileDetails:
                    {
                        query = @"SELECT 
                                    M.MODULE_NAME,
                                    MI.ACTION,
                                    MI.CONTROLLER,
                                    MI.MENU_NAME,
                                    M.STYLE,
                                    M.HAS_SUB,UA.[USERNAME] as USER_NAME,UA.EMAIL,'Admin' as USER_ROLE_NAME,'1' as USER_ROLE_ID
                                FROM
                                    USER_ROLES_RIGHTS AS RR
                                        INNER JOIN
                                    MENU_ITEMS AS MI ON MI.MENU_ID = RR.MENU_ITEM_ID
                                        AND MI.IS_DELETED!=1
                                        INNER JOIN
                                    MODULES AS M ON M.MODULES_ID = MI.PARENT_ID
										INNER JOIN 
                                    USER_ACCOUNT UA ON UA.ROLE=RR.ROLE_ID
										AND UA.USER_ID=@USER_ID
                                        AND UA.USER_TYPE=@USER_TYPE
                                        AND UA.IS_DELETED!=1
                                WHERE
                                     RR.IS_ACTIVE = 1   
									-- group by RR.MENU_ITEM_ID
                                ORDER BY M.MODULES_ORDER , MI.MENU_NAME";
                        break;
                    }
             
            }
            return query;
        }
    }
}
