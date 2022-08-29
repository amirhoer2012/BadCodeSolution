using SmellyDirtyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmellyDirtyApp.Bll
{
    public class UserBuilder
    {
        private Bll_User _userProfile;
        public UserBuilder(Bll_User userProfile)
        {
            _userProfile = userProfile;
        }
        public Bll_User GetUserModel(UserProfile userProfile)
        {
            _userProfile.UserName = userProfile.UserName;
            _userProfile.Password = userProfile.Password;
            _userProfile.RoleType = userProfile.RoleType;
            return _userProfile;

        }
    }
}
