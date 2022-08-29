using SmellyDirtyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmellyDirtyApp.Bll
{
    public class Bll_Teacher : Bll_Employee, ISallaryCalculator
    {
        public override void ShowDialog(Bll_User model)
        {
            new TeacherForm(model).ShowDialog();
        }
       public decimal CalculateSallary()
        {
            return 400;
        }

    }
}
