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
        #region 检查token
        // GET: api/User/"to"
        [Route("User/CheckToken")]
        public ApiReplyModel Get(string token)
        {
            DAL.IResponse.IUserResponse op = new DAL.Response.UserResponse();
            return op.CheckToken(token);
        }
        #endregion


        #region 获取token
        // GET: api/User/"to"
        [Route("User/Login")]
        public ApiReplyModel GetToKen(string code)
        {
            DAL.IResponse.IUserResponse op = new DAL.Response.UserResponse();
            return op.GetToken(code);
        }
        #endregion

        #region 添加新用户

        // POST: api/Users
        [Route("User/InsertNewUser")]
        public ApiReplyModel Post([FromBody]tbl_user model)
        {
            DAL.IResponse.IUserResponse op = new DAL.Response.UserResponse();
            return op.InsertNewUser(model);
        }
        #endregion
    }
}
