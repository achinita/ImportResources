using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServiceCenter_Connect.ServiceCenterWS;
using OutSystems.RuntimeCommon.Security;

namespace ServiceCenter_Connect
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        ServiceCenter _serviceCenter = null;
        public DialogResult LoginForm(ServiceCenter ss)
        {
            _serviceCenter = ss;
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            return this.ShowDialog();
        }
        private string username;
        public string Username
        {
            get { return username; }
        }
        private string password;
        public string Password
        {
            get { return password; }
        }
        private string hostname;
        public string Hostname
        {
            get { return hostname; }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            string pwd = Cryptutils.Encrypt(txtPass.Text);

            if (_serviceCenter.tryLogin(txtHost.Text, txtUser.Text, pwd, out errorMsg))
            {
                hostname = txtHost.Text;
                username = txtUser.Text;
                password = pwd;

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                password = null;
                MessageBox.Show(errorMsg, "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
