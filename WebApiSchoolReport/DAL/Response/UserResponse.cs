﻿using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Response
{
    public class UserResponse : IResponse.IUserResponse
    {
        #region 检查token
        public ApiReplyModel CheckToken(string token)
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
            return aj;
        }
        #endregion

        #region 获取token
        public ApiReplyModel GetToken(string code)
        {
            ApiReplyModel aj = new ApiReplyModel();
            aj.isSuccess = false;
            if (!string.IsNullOrEmpty(code))
            {
                tbl_appInfo modelApp = DHelper.DapperC.SelectSingle<tbl_appInfo>(null, " name='成绩报表' and status='1' ", "");
                if (modelApp != null)
                {
                    string url = $"https://api.weixin.qq.com/sns/jscode2session?appid={modelApp.appid}&secret={modelApp.appSecret}&js_code={code}&grant_type={modelApp.grant_type}";
                    HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                    request.Method = "GET";
                    request.ContentType = "application/x-www-form-urlencoded";//链接类型 
                    string openIdStr = GetResponseString((HttpWebResponse)request.GetResponse());
                    AppOpenidModel modelOpen = Newtonsoft.Json.JsonConvert.DeserializeObject<AppOpenidModel>(openIdStr);
                    if (!string.IsNullOrEmpty(modelOpen.openid))
                    {
                        aj.isSuccess = true;
                        aj.message = modelOpen.openid;
                    }
                }
            }
            return aj;
        }

        /// <summary> /// 从HttpWebResponse对象中提取响应的数据转换为字符串 /// </summary> 
        /// <param name="webresponse"></param> 
        /// <returns></returns> 
        public string GetResponseString(HttpWebResponse webresponse)
        {
            using (Stream s = webresponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(s, Encoding.UTF8); return reader.ReadToEnd();
            }
        }
        #endregion

        #region 添加新用户
        public ApiReplyModel InsertNewUser(tbl_user model)
        {
            ApiReplyModel aj = new ApiReplyModel();
            aj.isSuccess = false;
            if (model != null && !string.IsNullOrEmpty(model.token))
            {
                tbl_user modelUser = DHelper.DapperC.SelectSingle<tbl_user>(null, " token='" + model.token + "'", "");
                if (modelUser != null)
                {
                    modelUser.uptime = DateTime.Now;
                    DHelper.DapperC.Update(modelUser);
                }
                else
                {
                    model.usertype = 1;
                    model.status = 1;
                    model.addtime = DateTime.Now;
                    model.uptime = DateTime.Now;
                    DHelper.DapperC.Insert(model);
                }
                aj.isSuccess = true;
            }
            return aj;
        }
        #endregion
    }
}
