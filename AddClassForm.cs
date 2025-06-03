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
    public partial class AddClassForm : Form
    {

        public int UserID { get; set; }
        public AddClassForm()
        {
            InitializeComponent();
        }

        private void AddClassForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            AttendanceDBLocalDataSetTableAdapters.ClassesTableAdapter ada = new AttendanceDBLocalDataSetTableAdapters.ClassesTableAdapter();
            ada.AddClass(classNameTextBox.Text, UserID);
            Close();

        }

        private void classNameTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
