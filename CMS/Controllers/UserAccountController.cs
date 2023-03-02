using CMS.DAO;
using CMS.Utility;
using CMS.ViewModel.Model;
using CMS.ViewModel.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
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

        public JsonResult Userlogin(string sMobile, string sPassword)
        {

            CustomerViewModel customer = new CustomerViewModel();
            string Password = GetSha256FromString(sPassword);
            string sResult = string.Empty;

            customer.liuserdetails = DapperHandler.FetchAll<CUSTOMER_PERSONAL_INFO>(SQL.AccontSQL.GetAccountSQL(AccountSQLCommand.FetchLogindetails), new { @USERNAME = sMobile, @PASSWORD = Password }).ToList();
            if (customer.liuserdetails != null && customer.liuserdetails.Count > 0)
            {
                Session[Common.SESSION_VARIABLES.USER_ID] = customer.liuserdetails.FirstOrDefault().USER_ID;
                Session[Common.SESSION_VARIABLES.USER_TYPE] = customer.liuserdetails.FirstOrDefault().USER_TYPE;

                customer.liMenuList = DapperHandler.FetchAll<USER_ACCOUNT_DETAILS>(SQL.AccontSQL.GetAccountSQL(AccountSQLCommand.FetchUserProfileDetails),
                    new { @USER_ID = Session[Common.SESSION_VARIABLES.USER_ID], @USER_TYPE = Session[Common.SESSION_VARIABLES.USER_TYPE] });
                //ListtoDataTable ObjLitoData = new ListtoDataTable();

                //DataTable MenuList = ObjLitoData.ConvertToDataTable(customer.liMenuList);
                DataTable MenuList = new DataTable();

                MenuList.Columns.Add("USER_ROLE_NAME", typeof(string));
                MenuList.Columns.Add("USER_NAME", typeof(string));
                MenuList.Columns.Add("USER_ROLE_ID", typeof(string));
                MenuList.Columns.Add("MODULE_NAME", typeof(string));
                MenuList.Columns.Add("ACTION", typeof(string));
                MenuList.Columns.Add("CONTROLLER", typeof(string));
                MenuList.Columns.Add("MENU_NAME", typeof(string));
                MenuList.Columns.Add("HAS_SUB", typeof(string));
                MenuList.Columns.Add("STYLE", typeof(string));
                MenuList.Columns.Add("EMAIL", typeof(string));

                foreach (var person in customer.liMenuList)
                {
                    DataRow row = MenuList.NewRow();
                    row["USER_ROLE_NAME"] = person.USER_ROLE_NAME;
                    row["USER_NAME"] = person.USER_NAME;
                    row["USER_ROLE_ID"] = person.USER_ROLE_ID;
                    row["MODULE_NAME"] = person.MODULE_NAME;
                    row["ACTION"] = person.ACTION;
                    row["CONTROLLER"] = person.CONTROLLER;
                    row["MENU_NAME"] = person.ACTION;
                    row["HAS_SUB"] = person.HAS_SUB;
                    row["STYLE"] = person.STYLE;
                    row["EMAIL"] = person.EMAIL;


                    MenuList.Rows.Add(row);
                }


                if (MenuList != null && MenuList.Rows.Count > 0)
                {
                    //Session[Common.SESSION_VARIABLES.USER_ID] = MenuList.Rows[""].ToString();
                    Session[Common.SESSION_VARIABLES.USER_ROLE_NAME] = MenuList.Rows[0]["USER_ROLE_NAME"].ToString();
                    Session[Common.SESSION_VARIABLES.USER_ROLE_ID] = MenuList.Rows[0]["USER_ROLE_ID"].ToString();
                    // Session[Common.SESSION_VARIABLES.USER_TYPE] = MenuList.Rows[0][""].ToString();
                    //Session[Common.SESSION_VARIABLES.PHOTO] = customer.liMenuList.FirstOrDefault().PHOTO;
                    Session[Common.SESSION_VARIABLES.CONTROLLER_NAME] = MenuList.Rows[0]["CONTROLLER"].ToString();
                    Session[Common.SESSION_VARIABLES.ACTION_NAME] = MenuList.Rows[0]["ACTION"].ToString();
                    Session[Common.SESSION_VARIABLES.USERNAME] = MenuList.Rows[0]["USER_NAME"].ToString();
                    Session[Common.SESSION_VARIABLES.EMAIL] = MenuList.Rows[0]["EMAIL"].ToString();
                    Session[Common.SESSION_VARIABLES.MENU_ITEMS] = MenuList;
                }
            }
            else
            {
                //TempData["ErrorMessage"] = Common.Messages.InvalidUserCredentials;
                sResult = Common.ErrorCode.InternalServerError;

            }
            return Json(sResult);
            //return RedirectToAction("HomeIndex", "Home");
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
        //public class ListtoDataTable
        //{
        //    public DataTable ConvertToDataTable<T>(IList<T> data)
        //    {
        //        PropertyDescriptorCollection properties =
        //            TypeDescriptor.GetProperties(typeof(T));

        //        DataTable table = new DataTable();
        //        try
        //        {

        //            foreach (DataRow person in data)
        //            {
        //                DataRow row = dataTable.NewRow();
        //                row["Name"] = person.Name;
        //                row["Age"] = person.Age;
        //                dataTable.Rows.Add(row);
        //            }

        //            //    foreach (PropertyDescriptor prop in properties)
        //            //        table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

        //            //    foreach (T item in data)
        //            //    {
        //            //        DataRow row = table.NewRow();
        //            //        foreach (PropertyDescriptor prop in properties)
        //            //        {
        //            //            row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
        //            //        }
        //            //        table.Rows.Add(row);
        //            //    }
        //        }
        //        catch (Exception ex)
        //        {

        //            throw ex;
        //        }

                
        //        return table;
        //    }
        //}
    }
}
