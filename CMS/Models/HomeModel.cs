using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.Models
{
    #region Model
    public class HOMEMODEL
    {
        public string USER_ID { get; set; }
        public string EMAIL { get; set; }
        public string USER_NAME { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string MOBILE_NO { get; set; }
        public string USER_ROLE { get; set; }
        public string IS_LOCKED { get; set; }
        public string GST_FLAG { get; set; }
        public string GST_NUMBER { get; set;}
    }
    public class SUB_REQUIREMENT
    {
        public string REQUIREMENT_ID { get; set; }
        public string REQUIREMENT_NAME { get; set; }
        public string IS_LOCKED { get; set; }
    }

    #endregion
    
}
