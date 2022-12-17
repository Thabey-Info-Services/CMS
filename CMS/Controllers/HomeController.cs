using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMS.DAO;
using CMS.Utility;
using Newtonsoft.Json;
using CMS.ViewModel.Model;
using CMS.Models;
using CMS.ViewModel.ViewModel;

namespace CMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult HomeIndex()
        {


            return View();
        }

        #region New user save
        /// <summary>
        ///   New User Creation
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {

            return View();
        }
        public ActionResult NewRegistration()
        {
            SUB_REQUIREMENT ObjModel = new SUB_REQUIREMENT();
            string sOption = string.Empty;

            var RequirementList = (List<SUB_REQUIREMENT>)DapperHandler.FetchAll<SUB_REQUIREMENT>(SQL.AccontSQL.GetAccountSQL(AccountSQLCommand.FetchRequirement));
            if (RequirementList != null && RequirementList.Count > 0)
            {
                ObjModel.liRequirementList = new SelectList(RequirementList, Common.SUB_REQUIREMENT.REQUIREMENT_ID, Common.SUB_REQUIREMENT.REQUIREMENT_NAME);
            }

            //if (RequirementList != null && RequirementList.Count > 0)
            //{
            //    foreach (var item in RequirementList)
            //    {
            //        sOption += "<option value='" + item.REQUIREMENT_ID + "' >" + item.REQUIREMENT_NAME + "</option>";
            //    }
            //}
            return View(ObjModel);
        }
        public JsonResult CheckUser(string sMobile)
        {
            CUSTOMER_PERSONAL_INFO ObjModel = new CUSTOMER_PERSONAL_INFO();
            string Result1 = string.Empty;
            try
            {
                if (sMobile != null)
                {
                    var Result = (List<CUSTOMER_PERSONAL_INFO>)DapperHandler.FetchAll<CUSTOMER_PERSONAL_INFO>(SQL.AccontSQL.GetAccountSQL(AccountSQLCommand.FetchLogindetails), new { @MOBILE_NO = sMobile });
                    Result1 = Result.Count.ToString();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Json(Result1);

        }
        public JsonResult CreateNewUser(string sJsonvalue)
        {
            CUSTOMER_PERSONAL_INFO ObjViewModel = new CUSTOMER_PERSONAL_INFO();

            var Result = JsonConvert.DeserializeObject<CUSTOMER_PERSONAL_INFO>(sJsonvalue);
            try
            {
                if (Result != null)
                {
                    var returnvalue = DapperHandler.SaveOrUpdate(SQL.AccontSQL.GetAccountSQL(AccountSQLCommand.SaveNewUser),new { });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Json(ObjViewModel);
        }
        #endregion
    }

}
