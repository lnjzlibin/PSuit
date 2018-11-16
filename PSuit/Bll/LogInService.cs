using PSuite.Dal;
using PSuite.Models;
using System.Collections.Generic;
using System.Data;

namespace PSuite.Bll
{
    public class LogInService
    {
        private UserService service;
        public LogInService()
        {
            service = new UserService();
        }
        public bool HasUserAndAuthority(User user)
        {
            List<User> users = service.QueryAllUser();
            foreach (User item in users)
            {
                if (item.UserName.Equals(user.UserName) && item.Password.Equals(user.Password) && item.IsValid.Equals("true"))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
