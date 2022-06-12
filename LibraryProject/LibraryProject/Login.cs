using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (tboxUsername.Text == "admin" && textBoxPassword.Text == "adminlogin")
            {
                this.Visible = false;
                HomePage homePage = new HomePage();
                homePage.ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Username/Password is wrong!");
            }
            
        }
    }
}
