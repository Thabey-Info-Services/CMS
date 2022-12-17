using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CMS.ViewModel.Model;
using CMS.Utility;
using CMS.SQL.UserAccount;
using CMS.DAO;
using System.Web.Mvc;

namespace CMS.ViewModel.ViewModel
{
    public class AccountViewModel:IDisposable
    {
        ResultArgs resultArgs = new ResultArgs();
        DataValue dv = new DataValue();
        string sSQL = string.Empty;
        public LoginViewModel objLoginViewModel { get; set; }
        public SelectList SupRoleList { get; set; }
        public List<USER_ACCOUNT_INFO> ListUserAccount { get; set; }
        
    
   

        public void Dispose()
        {
            GC.Collect();
        }
    }
}
