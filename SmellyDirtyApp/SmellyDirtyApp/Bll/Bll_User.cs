using SmellyDirtyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmellyDirtyApp.Bll
{
    public abstract class Bll_User:UserProfile
    {
        public abstract void ShowDialog(Bll_User model);
        public void Update(Bll_User model)
        {

        }
    }
}
