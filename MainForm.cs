using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceSystem.AttendanceDBLocalDataSetTableAdapters;

/*
 * 
 * TODO: C# Visual Attendance System Full project + SQL Server Database Full Source Code
 *                          AT: 28:53
 *                          
 */
namespace AttendanceSystem
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {

        public int loggedIn { get; set; }
        public int UserID { get; set; }

        public MainForm()
        {
            InitializeComponent();
            loggedIn = 0;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendanceDBLocalDataSet.Records' table. You can move, or remove it, as needed.
            this.recordsTableAdapter.Fill(this.attendanceDBLocalDataSet.Records);
            // TODO: This line of code loads data into the 'attendanceDBLocalDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.attendanceDBLocalDataSet.Students);
            // TODO: This line of code loads data into the 'attendanceDBLocalDataSet.Classes' table. You can move, or remove it, as needed.


        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Activated(object sender, EventArgs e)
        {

            if (loggedIn == 0)
            {

                // Open Login Form
                LoginForm newLogin = new LoginForm();
                newLogin.ShowDialog();

                if (newLogin.loginFlag == false)
                {

                    Close();

                }
                else
                {

                    UserID = newLogin.UserID;
                    statLabelUser.Text = UserID.ToString();
                    statLabelUserName.Text = newLogin.UserName;

                    loggedIn = 1;

                    this.classesTableAdapter.Fill(this.attendanceDBLocalDataSet.Classes);
                    classesBindingSource.Filter = "UserID = '" + UserID.ToString() + "'";

                }

            }


        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            AddClassForm addClass = new AddClassForm();
            addClass.UserID = this.UserID;
            addClass.ShowDialog();

        }

        private void addStudentsButton_Click(object sender, EventArgs e)
        {
            StudentsForm students = new StudentsForm();
            students.ClassName = classComboBox.Text;
            students.ClassID = (int)classComboBox.SelectedValue;

            students.ShowDialog();

        }

        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getValuesButton_Click(object sender, EventArgs e)
        {

            AttendanceDBLocalDataSetTableAdapters.RecordsTableAdapter ada = new AttendanceDBLocalDataSetTableAdapters.RecordsTableAdapter();
            DataTable dt = ada.GetDataBy((int)classComboBox.SelectedValue, dateTimePicker.Text);

            if (dt.Rows.Count > 0)
            {

                // we have records and can edit
                DataTable dt_new = ada.GetDataBy((int)classComboBox.SelectedValue, dateTimePicker.Text);
                dataGridView1.DataSource = dt_new;

            }
            else
            {

                // create a record for each student
                // Get the class students list
                StudentsTableAdapter students_adapter = new StudentsTableAdapter();
                DataTable dt_students = students_adapter.GetDataByClassID((int)classComboBox.SelectedValue);

                foreach(DataRow row in dt_students.Rows)
                {

                    // insert a new record for this student

                    ada.InsertQuery((int)row[0], (int)classComboBox.SelectedValue, dateTimePicker.Text, "", row[1].ToString(), classComboBox.Text);


                }

                DataTable dt_new = ada.GetDataBy((int)classComboBox.SelectedValue, dateTimePicker.Text);
                dataGridView1.DataSource = dt_new;

            }

            this.recordsTableAdapter.Fill(this.attendanceDBLocalDataSet.Records);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            AttendanceDBLocalDataSetTableAdapters.RecordsTableAdapter ada = new AttendanceDBLocalDataSetTableAdapters.RecordsTableAdapter();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (row.Cells[1].Value != null)
                {

                    ada.UpdateQuery(row.Cells[1].Value.ToString(), row.Cells[0].Value.ToString(), (int)classComboBox.SelectedValue, dateTimePicker.Text);

                }

            }

            DataTable dt_new = ada.GetDataBy((int)classComboBox.SelectedValue, dateTimePicker.Text);
            dataGridView1.DataSource = dt_new;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void valuesReportsButton_Click(object sender, EventArgs e)
        {

            // get students

            StudentsTableAdapter students_adapter = new StudentsTableAdapter();
            DataTable dt_students = students_adapter.GetDataByClassID((int)classReportsComboBox.SelectedValue);

            AttendanceDBLocalDataSetTableAdapters.RecordsTableAdapter ada = new AttendanceDBLocalDataSetTableAdapters.RecordsTableAdapter();

            //loop through students and get the values

            foreach (DataRow row in dt_students.Rows)
            {

                int presence_count = (int)ada.GetDataByReport(dateTimePickerReports.Value.Month, row[1].ToString(), "present").Rows[0][6];
                int abscence_count = (int)ada.GetDataByReport(dateTimePickerReports.Value.Month, row[1].ToString(), "abscent").Rows[0][6];
                int late_count = (int)ada.GetDataByReport(dateTimePickerReports.Value.Month, row[1].ToString(), "late").Rows[0][6];
                int excused_count = (int)ada.GetDataByReport(dateTimePickerReports.Value.Month, row[1].ToString(), "excused").Rows[0][6];

                ListViewItem listItem = new ListViewItem();

                listItem.Text = row[1].ToString();
                listItem.SubItems.Add(presence_count.ToString());
                listItem.SubItems.Add(abscence_count.ToString());
                listItem.SubItems.Add(late_count.ToString());
                listItem.SubItems.Add(excused_count.ToString());

                reportsListView.Items.Add(listItem);

            }

            // add to listview


        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            RegisterForm reg = new RegisterForm();
            reg.ShowDialog();

        }

        private void statLabelUser_Click(object sender, EventArgs e)
        {

        }

        private void reportsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
