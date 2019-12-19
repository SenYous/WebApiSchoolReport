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
    }
}