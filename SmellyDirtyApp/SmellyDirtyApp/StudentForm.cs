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
    public partial class StudentForm : Form
    {
        public Bll_User Model { get; set; }
        public StudentForm()
        {
            InitializeComponent();
        }
        public StudentForm(Bll_User model)
        {
            InitializeComponent();
            Model = model;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Model.Update(Model);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {      
            Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Bll_Course().SelectCourse(Guid.Empty);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Bll_Course().GetResault();
        }
    }
}
