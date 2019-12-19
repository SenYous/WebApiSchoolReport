using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiSchoolReport.Controllers
{
    public class UsersController : ApiController
    {
        // GET: api/Users
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Users/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }

        // GET: api/User/"to"
        [Route("User/CheckToken")]
        public ApiReplyModel Get(string token)
        {
            ApiReplyModel aj = new ApiReplyModel();
            aj.isSuccess = false;
            if (!string.IsNullOrEmpty(token))
            {
                var model = DHelper.DapperC.SelectSingle<tbl_user>(null, " token='" + token + "' and status=1", "");
                if (model != null)
                {
                    model.uptime = DateTime.Now;
                    DHelper.DapperC.Update(model);

                    aj.isSuccess = true;
                }
                else
                {
                    aj.code = 1000;
                }
            }
            else
            {
                aj.code = 500;
            }
            return aj;
        }

    }
}
