using SmellyDirtyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SmellyDirtyApp.Bll
{
    public class Bll_Student : Bll_User
    {
        public override void ShowDialog(Bll_User model)
        {
            new StudentForm(model).ShowDialog();
        }
    }
}
