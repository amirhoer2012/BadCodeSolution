using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmellyDirtyApp.Models
{
    public class EmployeeProfile:UserInfo
    {
        public int EmployeeId { get; set; }
        public decimal MonthlySalary { get; set; }
    }
}
