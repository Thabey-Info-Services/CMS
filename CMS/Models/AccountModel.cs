using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.Models
{
    public class AccountModel
    {

        public int ID { get; set; }
        public string NAME { get; set; }
        public string FIRST_NAME { get; set; }
        public string MOBILENO { get; set; }
        public string USER_ROLE { get; set; }
    }

    public class CustomerModel
    {

        public int ID { get; set; }
        public string name { get; set; }
        public string FIRST_NAME { get; set; }
        public string MOBILE_NO { get; set; }
        public string EMAIL { get; set; }
        public string GST_FLAG { get; set; }
        public string GST_NUMBER { get; set; }

    }
}