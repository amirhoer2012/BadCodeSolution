using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmellyDirtyApp.Models
{
    public class DataBase
    {
        public static IEnumerable<UserInfo> Users = new List<UserInfo>()
        {
            new UserInfo("std1", "123", "Student"),
            new UserInfo("tch1", "456", "Teacher"),
            new UserInfo("emp1", "789", "Employee"),
            new UserInfo("man1", "1234", "Manager")
        };
    }
}
