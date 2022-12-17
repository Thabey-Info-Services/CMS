using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.ViewModel.Model;
using System.Web.Mvc;
using CMS.Utility;
using CMS.DAO;
using CMS.SQL.Student;
using System.ComponentModel;

namespace CMS.ViewModel.ViewModel
{
    public class CustomerViewModel:IDisposable
    {
        ResultArgs resultArgs = new ResultArgs();
        DataValue dv = new DataValue();
        string sSQL = string.Empty;
        public string sCaste = string.Empty;
        public string sOption = string.Empty;
        public string sAcademicyear = string.Empty;
        public string sBeginyear = string.Empty;

        public string sExpiredyear = string.Empty;
        public string sExammonth = string.Empty;
        public string sBatchyear = string.Empty;
        public string sCertificatetype = string.Empty;

        public List<CUSTOMER_PERSONAL_INFO> liHomeModel { get; set; }

        [DisplayName("Shift")]
        public SelectList RequirementList { get; set; }

        #region Dispose
        public void Dispose()
        {
            GC.Collect();
        }
        #endregion

    }

    // DDL Classes ...
    public class DDLForSibling
    {
        public string Program { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
        public string Option { get; set; }
    }

    public class DDLForTalents
    {
        public string Grade { get; set; }
        public string TalentActivity { get; set; }
        public string TalentArea { get; set; }
    }




}
