using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiSchoolReport.Controllers
{
    public class CommonController : ApiController
    {

        #region 查询省
        [Route("Common/GetProvince")]
        public ApiReplyModel GetProvince()
        {
            DAL.IResponse.IUserResponse op = new DAL.Response.UserResponse();
            return op.GetProvince();
        }
        #endregion

        #region 查询市,区

        [Route("Common/GetCity")]
        public ApiReplyModel GetCity(int disType, string pid)
        {
            DAL.IResponse.IUserResponse op = new DAL.Response.UserResponse();
            return op.GetCity(disType, pid);
        }
        #endregion


        #region MongoDB操作
        [Route("Common/MongoDBPlay")]
        public ApiReplyModel MongoDBPlay()
        {
            ApiReplyModel ret = new ApiReplyModel();

            return ret;
        }
        #endregion
    }
}
