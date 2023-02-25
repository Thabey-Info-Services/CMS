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
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    public class HomeController : Controller
    {
        ErrorLog ObjError = new ErrorLog();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult HomeIndex()
        {


            return View();
        }

        public ActionResult Test()
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
        /// <summary>
        ///   Already have login page
        /// </summary>
        /// <returns></returns>
        public ActionResult Login2()
        {
            CUSTOMER_PERSONAL_INFO ObjViewModel = new CUSTOMER_PERSONAL_INFO();
            return View(ObjViewModel);
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

            return View(ObjModel);
        }

        [HttpPost]
        public JsonResult CheckUser(string sMobile)
        {
            CUSTOMER_PERSONAL_INFO ObjModel = new CUSTOMER_PERSONAL_INFO();
            string sResult = string.Empty;
            try
            {
                if (sMobile != null)
                {
                    ObjModel.lipersonalinfo = DapperHandler.FetchAll<CUSTOMER_PERSONAL_INFO>(SQL.AccontSQL.GetAccountSQL(AccountSQLCommand.FetchUserdetails), new { @USERNAME = sMobile }).ToList();
                    if (string.IsNullOrEmpty(ObjModel.lipersonalinfo.FirstOrDefault().USER_NAME))
                    {
                        ViewBag.MOBILE_NO = sMobile;
                    }
                    else
                    {
                        sResult = Common.Messages.MobileNumberExistAlready;
                    }
                }

            }
            catch (Exception ex)
            {

                ObjError.WriteError("Home", "CheckUser", ex.ToString());
            }
            return Json(sResult, JsonRequestBehavior.AllowGet);

        }

        public JsonResult CreateNewUser(string sJsonvalue)
        {
            CUSTOMER_PERSONAL_INFO ObjViewModel = new CUSTOMER_PERSONAL_INFO();
            var sResult = string.Empty;
            var Result = JsonConvert.DeserializeObject<CUSTOMER_PERSONAL_INFO>(sJsonvalue);
            try
            {
                if (Result != null)
                {
                     sResult = DapperHandler.SaveOrUpdate(SQL.AccontSQL.GetAccountSQL(AccountSQLCommand.SaveNewUser),
                        new {Result.FIRST_NAME,Result.LAST_NAME,Result.EMAIL,Result.REQUIREMENT,Result.PASSWORD,Result.CONFIRM_PASSWORD }).ToString();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Json(sResult,JsonRequestBehavior.AllowGet);
        }
        #endregion
    }

}
