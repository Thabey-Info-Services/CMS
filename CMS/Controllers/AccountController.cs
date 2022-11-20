using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CMS.Controllers
{
    public class AccountController : ApiController
    {
        AccountModel[] ObjLogin = new AccountModel[]
           {
               new AccountModel{ID=1,NAME ="Suganya" },
                new AccountModel{ID=1,NAME="Kannabiran" },
                 new AccountModel{ID=1,NAME="Ashok" },
                  new AccountModel{ID=1,NAME="Parkavi" }
          };
        // GET api/values
        [HttpGet]
        [Route("api/Get/")]
        public IEnumerable<AccountModel> Get()
        {
            return ObjLogin;
        }

        // GET api/values/5
        [HttpGet]
        [Route("api/GetAccount/{id}")]
        public string GetAccount(int id)
        {
            var AccountList = ObjLogin.FirstOrDefault(x => x.ID == id);
            if (AccountList == null)
                return NotFound().ToString();
            else
                return AccountList.ToString();

        }

        // POST api/values
        [HttpGet]
        [Route("api/GetAccount/{value}")]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
