using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using validRegistration.Model;
using validRegistration.Presentation;

namespace validRegistration
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegisterPerson reg = new RegisterPerson();
            reg.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Controls controls = new Controls();
            controls.access(txbUsername.Text, txbPassword.Text);
            if (controls.message.Equals(""))
            {
                if (controls.have)
                {
                    MessageBox.Show("allowed access", "Login..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Welcome welcome = new Welcome();
                    welcome.Show();
                }
                else
                {
                    MessageBox.Show("Acess not found! Check uername and password.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controls.message);
            }
           
        }
    }
}
