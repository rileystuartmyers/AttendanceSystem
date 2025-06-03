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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void confirmTextBox_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void userTextBox_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {

            if (passwordTextBox.Text != confirmTextBox.Text)
            {

                MessageBox.Show("Passwords do not match!");
                confirmTextBox.Text = "";

                return;


            }

            AttendanceDBLocalDataSetTableAdapters.UsersTableAdapter ada = new AttendanceDBLocalDataSetTableAdapters.UsersTableAdapter();
            ada.InsertQuery(userTextBox.Text, passwordTextBox.Text);
            
            MessageBox.Show("Registration Successful!");
            Close();

        }
    }
}
