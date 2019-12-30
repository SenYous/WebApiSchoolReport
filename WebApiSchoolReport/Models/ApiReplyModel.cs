using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class ApiReplyModel
    {
        public bool isSuccess { get; set; }
        public string message { get; set; }
        public int code { get; set; }

        public object row { get; set; }
    }

    public class AppOpenidModel
    { 
        public string openid { get; set; }
        public string session_key { get; set; }
        public string unionid { get; set; }
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}