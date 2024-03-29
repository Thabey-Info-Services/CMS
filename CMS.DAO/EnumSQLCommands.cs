﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DAO
{
    public class EnumSQLCommands
    {
    }
    public enum AccountSQLCommand
    {

        FetchLogindetails,
        FetchRequirement,
        SaveNewUser,
        FetchUserProfileDetails,
        DeteleUserByAdmin,
        FetchMenuItemsByRole, FetchUserdetails,
    }
    public enum UserAccountSQLCommands
    {
        FetchUserCredentials,
        ValidateUserRole,
        FetchMenuItemsByRole,
        FetchCollegeInfo,
        FetchActiveYear,
        SaveUserAccount,
        UpdateUserAccount,
        FetchUserAccountByRoleAndId,
        FetchUserAccountByName,
        FetchSupRole,
        FetchUserType,
        DeleteUserAccount,
        UpdateUserAccountImage,
    }
}
