using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmellyDirtyApp.Models;


namespace SmellyDirtyApp.Bll
{
    public class Bll_Employee : Bll_User, ISallaryCalculator
    {
        public decimal CalculateSallary()
        {
            return 1000;
        }

        public override void ShowDialog(Bll_User model)
        {
            new EmployeeForm(model).ShowDialog();
        }
    }
}
