using PSuite.Dal;
using PSuite.Models;
using System.Collections.Generic;
using System.Data;

namespace PSuite.Bll
{
    public class UserService
    {
        private UserDal dal;
        public UserService()
        {
            dal = new UserDal();
        }
        public int AddUser(User user)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("User_Name", user.UserName);
            dic.Add("Password", user.Password);
            dic.Add("isValid", "true");
            return dal.Add(dic);
        }
        public int DeleteUser(int userID)
        {
            return dal.Delete(userID);
        }
        public int UpdateUser(User user)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("User_Name", user.UserName);
            dic.Add("Password", user.Password);
            dic.Add("isValid", "true");
            return dal.Update(user.UserID, dic);
        }
        public List<User> QueryAllUser()
        {
            List<User> users = new List<User>();
            DataTable dt = dal.QueryAll();
            foreach (DataRow dr in dt.Rows)
            {
                User user = new User();
                user.UserID = dr.Field<int>("User_ID");
                user.UserName = dr.Field<string>("User_Name");
                user.Password = dr.Field<string>("Password");
                user.IsValid= dr.Field<string>("IsValid");
                users.Add(user);
            }
            return users;
        }
        public User QueryUserByID(int ID)
        {
            User user=null;
            DataTable dt = dal.QueryByID(ID);
            if (dt.Rows.Count > 0)
            {
                user = new User();
                user.UserID = dt.Rows[0].Field<int>("User_ID");
                user.UserName = dt.Rows[0].Field<string>("User_Name");
                user.Password = dt.Rows[0].Field<string>("Password");
                user.IsValid = dt.Rows[0].Field<string>("IsValid");
            }            
            return user;
        }
    }
}
