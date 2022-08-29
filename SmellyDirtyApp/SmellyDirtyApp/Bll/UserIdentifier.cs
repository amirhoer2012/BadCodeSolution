using SmellyDirtyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmellyDirtyApp.Bll
{
    public class UserIdentifier
    {
        public Bll_User LogIn(string userName, string password)
        {
            UserProfile userProfile = DataBase.Users.SingleOrDefault(w =>
            w.UserName == userName && w.Password == password);

            if (userProfile == null)
                throw new Exception("نام کاربری و کلمه عبور صحیح نمیباشد");

            UserBuilder builder = new UserBuilder(GetUser(userProfile.RoleType));
            return builder.GetUserModel(userProfile);
        }

        public Bll_User GetUser(string roleType)
        {
            switch (roleType)
            {
                case "Student":
                    return new Bll_Student();
                case "Teacher":
                    return new Bll_Teacher();
                case "Employee":
                    return new Bll_Employee();
                default:
                    throw new Exception("نوع کاربری، در سیستم تعریف نشده است");
            }
        }
    }
}
