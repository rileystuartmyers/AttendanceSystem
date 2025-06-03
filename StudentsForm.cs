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
    public partial class StudentsForm : Form
    {

        public int ClassID { get; set; }
        public string ClassName { get; set; }

        public StudentsForm()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendanceDBLocalDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.attendanceDBLocalDataSet.Students);
            classIDLabel.Text = ClassID.ToString();
            classNameLabel.Text = ClassName.ToString();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate(); // Ensure all controls are validated  
                this.studentsBindingSource.EndEdit(); // End edit mode for the binding source  
                int val = this.studentsTableAdapter.Update(attendanceDBLocalDataSet.Students); // Update the database  

                if (val > 0)
                {
                    MessageBox.Show($"{val} record(s) updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No records were updated. Please check your changes.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
