using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPSignIn
{
    public partial class RegisterUserView : Form
    {
        public RegisterUserView()
        {
            InitializeComponent();
        }

        private void btnRegUser_Click(object sender, EventArgs e)
        {
            string username = txtRegUName.Text;
            string password = txtRegPWord.Text;
            string rePassword = txtRegPWord2.Text;

            new User(username, password);
        }
    }
}
