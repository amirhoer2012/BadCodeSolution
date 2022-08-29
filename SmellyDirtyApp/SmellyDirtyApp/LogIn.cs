using SmellyDirtyApp.Bll;
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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
                    throw new Exception("نام کاربری و کلمه عبور اجباری است..");
                else
                {
                    var identifier = new UserIdentifier();
                    Bll_User user = identifier.LogIn(txtUsername.Text, txtPassword.Text);
                    this.Hide();
                    user.ShowDialog(user);
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                foreach (var Control in this.Controls)
                {
                    if (Control is TextBox)
                        ((TextBox)Control).Text = String.Empty;
                }
            }
        }
    }
}
