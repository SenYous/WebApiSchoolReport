using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IResponse
{
    public interface IUserResponse
    {
        ApiReplyModel CheckToken(string token);
        ApiReplyModel GetToken(string token);
        ApiReplyModel InsertNewUser(tbl_user model);
    }
}
