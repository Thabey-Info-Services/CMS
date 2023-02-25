using CMS.DAO;
using CMS.Utility;
using CMS.ViewModel.Model;
using CMS.ViewModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CMS.Controllers
{
    public class UserAccountController : Controller
    {
        // GET: UserAccount
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Userlogin(string sMobile, string sPassword)
        {

            CustomerViewModel customer = new CustomerViewModel();
            string sPasswoed = GetSha256FromString(sPassword);
            string sResult = string.Empty;

            customer.liuserdetails = DapperHandler.FetchAll<CUSTOMER_PERSONAL_INFO>(SQL.AccontSQL.GetAccountSQL(AccountSQLCommand.FetchLogindetails), new { @USERNAME = sMobile, @PASSWORD = sPasswoed }).ToList();
            if (customer.liuserdetails != null && customer.liuserdetails.Count > 0)
            {
                Session[Common.SESSION_VARIABLES.USER_ID] = customer.liuserdetails.FirstOrDefault().USER_ID;
                Session[Common.SESSION_VARIABLES.USER_TYPE] = customer.liuserdetails.FirstOrDefault().USER_TYPE;

                customer.liMenuList = DapperHandler.FetchAll<USER_ACCOUNT_DETAILS>(SQL.AccontSQL.GetAccountSQL(AccountSQLCommand.FetchUserProfileDetails),
                    new { @USER_ID = Session[Common.SESSION_VARIABLES.USER_ID], @USER_TYPE = Session[Common.SESSION_VARIABLES.USER_TYPE] }).ToList();

                if (customer.liMenuList != null && customer.liMenuList.Count > 0)
                {
                    Session[Common.SESSION_VARIABLES.USER_ID] = customer.liMenuList.FirstOrDefault().USER_ID;
                    Session[Common.SESSION_VARIABLES.USER_ROLE_NAME] = customer.liMenuList.FirstOrDefault().USER_ROLE_NAME;
                    Session[Common.SESSION_VARIABLES.USER_ROLE_ID] = customer.liMenuList.FirstOrDefault().USER_ROLE;
                    Session[Common.SESSION_VARIABLES.USER_TYPE] = customer.liMenuList.FirstOrDefault().USER_TYPE;
                    //Session[Common.SESSION_VARIABLES.PHOTO] = customer.liMenuList.FirstOrDefault().PHOTO;
                    Session[Common.SESSION_VARIABLES.CONTROLLER_NAME] = customer.liMenuList.FirstOrDefault().CONTROLLER;
                    Session[Common.SESSION_VARIABLES.ACTION_NAME] = customer.liMenuList.FirstOrDefault().ACTION;
                    Session[Common.SESSION_VARIABLES.USERNAME] = customer.liuserdetails.FirstOrDefault().USER_NAME;
                    Session[Common.SESSION_VARIABLES.EMAIL] = customer.liuserdetails.FirstOrDefault().EMAIL;
                    Session[Common.SESSION_VARIABLES.MENU_ITEMS] = customer.liMenuList.ToList();
                }
            }
            else
            {
                //TempData["ErrorMessage"] = Common.Messages.InvalidUserCredentials;
                sResult = Common.Messages.InvalidUserCredentials;
                return RedirectToAction("Login2", "Home");
            }
            return Json(sResult,JsonRequestBehavior.AllowGet);
        }

        #region Encryption Method
        public static string GetSha256FromString(string strData)
        {
            var Message = Encoding.ASCII.GetBytes(strData);
            SHA256Managed hashString = new SHA256Managed();
            string Hex = string.Empty;
            var Hashvalue = hashString.ComputeHash(Message);
            foreach (byte x in Hashvalue)
            {
                Hex += string.Format("{0:x2}", x);
            }
            return Hex;
        }
        #endregion
    }
}
