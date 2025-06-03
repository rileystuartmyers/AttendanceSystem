using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystem
{
    public partial class LoginForm : Form
    {

        public bool loginFlag { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            loginFlag = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e) {}
        private void usernameBox_Click(object sender, EventArgs e) {}
        private void metroLabel2_Click(object sender, EventArgs e) {}

        private void loginButton_Click(object sender, EventArgs e)
        {
            AttendanceDBLocalDataSetTableAdapters.UsersTableAdapter userAda = new AttendanceDBLocalDataSetTableAdapters.UsersTableAdapter();
            DataTable dt = userAda.GetDataByUserAndPassword(usernameBox.Text, passwordBox.Text);

            if (dt.Rows.Count > 0)
            {

                MessageBox.Show("Login successful.");
                UserID = int.Parse(dt.Rows[0]["UserID"].ToString());
                UserName = usernameBox.Text;
                loginFlag = true;

                Close();

            } else
            {

                // Invalid table
                MessageBox.Show("Access denied.");
                loginFlag = false;

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            RegisterForm reg = new RegisterForm();
            reg.ShowDialog();


        }
    }
}
