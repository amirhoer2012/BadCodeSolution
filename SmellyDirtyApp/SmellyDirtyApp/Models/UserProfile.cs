using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmellyDirtyApp.Models
{
    public class UserProfile:BaseModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RoleType { get; set; }
    }
}
