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
    public partial class EmployeeForm : StudentForm
    {
        public EmployeeForm() { InitializeComponent();}
        public EmployeeForm(Bll_User model) : base(model)
        {
            InitializeComponent();
        }

        protected void button6_Click(object sender, EventArgs e)
        {
            (Model as ISallaryCalculator).CalculateSallary();
        }
        protected void button1_Click_1(object sender, EventArgs e)
        {
            new Bll_Course().OfferCourses();
        }

        protected void button5_Click_1(object sender, EventArgs e)
        {
            new Bll_Course().SetResault(Guid.Empty,Guid.Empty,20);
        }
    }
}
