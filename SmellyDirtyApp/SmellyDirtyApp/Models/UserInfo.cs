using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmellyDirtyApp.Models
{
    public class UserInfo:UserProfile
    {
        public UserInfo() { }
        public UserInfo(string userName,string password , string roleType)
        {
            UserName = userName;
            Password = password;
            RoleType = roleType;
        }
        public string Name { get; set; }
        public string Family { get; set; }
        public string CetificateCode { get; set; }
        public string NationalId { get; set; }
        public string PhoneNumber { get; set; }
       
    }
}
