using SmellyDirtyApp.Bll;
using SmellyDirtyApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmellyDirtyApp
{
    public partial class TeacherForm : EmployeeForm
    {
        public TeacherForm(Bll_User model):base(model)
        {
            InitializeComponent();
        }
    }
}
