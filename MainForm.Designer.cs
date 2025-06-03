namespace AttendanceSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.attendanceTabs = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.registerButton = new MetroFramework.Controls.MetroButton();
            this.getValuesButton = new MetroFramework.Controls.MetroButton();
            this.addStudentsButton = new MetroFramework.Controls.MetroButton();
            this.addClassButton = new MetroFramework.Controls.MetroButton();
            this.clearButton = new MetroFramework.Controls.MetroButton();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceDBLocalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceDBLocalDataSet = new AttendanceSystem.AttendanceDBLocalDataSet();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.classComboBox = new MetroFramework.Controls.MetroComboBox();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.valuesReportsButton = new MetroFramework.Controls.MetroButton();
            this.dateReportsLabel = new MetroFramework.Controls.MetroLabel();
            this.classReportsLabel = new MetroFramework.Controls.MetroLabel();
            this.dateTimePickerReports = new System.Windows.Forms.DateTimePicker();
            this.classReportsComboBox = new MetroFramework.Controls.MetroComboBox();
            this.reportsListView = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.userNameStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statLabelUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.attendanceDBLocalDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new AttendanceSystem.AttendanceDBLocalDataSetTableAdapters.ClassesTableAdapter();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new AttendanceSystem.AttendanceDBLocalDataSetTableAdapters.StudentsTableAdapter();
            this.recordsTableAdapter = new AttendanceSystem.AttendanceDBLocalDataSetTableAdapters.RecordsTableAdapter();
            this.attendanceTabs.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDBLocalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDBLocalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDBLocalDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // attendanceTabs
            // 
            this.attendanceTabs.Controls.Add(this.metroTabPage1);
            this.attendanceTabs.Controls.Add(this.metroTabPage2);
            this.attendanceTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendanceTabs.Location = new System.Drawing.Point(20, 60);
            this.attendanceTabs.Name = "attendanceTabs";
            this.attendanceTabs.SelectedIndex = 0;
            this.attendanceTabs.Size = new System.Drawing.Size(760, 370);
            this.attendanceTabs.TabIndex = 0;
            this.attendanceTabs.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.registerButton);
            this.metroTabPage1.Controls.Add(this.getValuesButton);
            this.metroTabPage1.Controls.Add(this.addStudentsButton);
            this.metroTabPage1.Controls.Add(this.addClassButton);
            this.metroTabPage1.Controls.Add(this.clearButton);
            this.metroTabPage1.Controls.Add(this.saveButton);
            this.metroTabPage1.Controls.Add(this.dataGridView1);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.dateTimePicker);
            this.metroTabPage1.Controls.Add(this.classComboBox);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(752, 328);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Attendance";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(681, 284);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 12;
            this.registerButton.Text = "Register";
            this.registerButton.UseSelectable = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // getValuesButton
            // 
            this.getValuesButton.Location = new System.Drawing.Point(432, 31);
            this.getValuesButton.Name = "getValuesButton";
            this.getValuesButton.Size = new System.Drawing.Size(75, 23);
            this.getValuesButton.TabIndex = 11;
            this.getValuesButton.Text = "Get Values";
            this.getValuesButton.UseSelectable = true;
            this.getValuesButton.Click += new System.EventHandler(this.getValuesButton_Click);
            // 
            // addStudentsButton
            // 
            this.addStudentsButton.Location = new System.Drawing.Point(625, 63);
            this.addStudentsButton.Name = "addStudentsButton";
            this.addStudentsButton.Size = new System.Drawing.Size(98, 23);
            this.addStudentsButton.TabIndex = 10;
            this.addStudentsButton.Text = "Add Students";
            this.addStudentsButton.UseSelectable = true;
            this.addStudentsButton.Click += new System.EventHandler(this.addStudentsButton_Click);
            // 
            // addClassButton
            // 
            this.addClassButton.Location = new System.Drawing.Point(625, 34);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(98, 23);
            this.addClassButton.TabIndex = 9;
            this.addClassButton.Text = "Add Class";
            this.addClassButton.UseSelectable = true;
            this.addClassButton.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(352, 96);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseSelectable = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(352, 67);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseSelectable = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNameDataGridViewTextBoxColumn,
            this.Status});
            this.dataGridView1.DataSource = this.recordsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 240);
            this.dataGridView1.TabIndex = 6;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // recordsBindingSource
            // 
            this.recordsBindingSource.DataMember = "Records";
            this.recordsBindingSource.DataSource = this.attendanceDBLocalDataSetBindingSource;
            // 
            // attendanceDBLocalDataSetBindingSource
            // 
            this.attendanceDBLocalDataSetBindingSource.DataSource = this.attendanceDBLocalDataSet;
            this.attendanceDBLocalDataSetBindingSource.Position = 0;
            // 
            // attendanceDBLocalDataSet
            // 
            this.attendanceDBLocalDataSet.DataSetName = "AttendanceDBLocalDataSet";
            this.attendanceDBLocalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(207, 12);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Select Date:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Select Class:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(207, 34);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 3;
            // 
            // classComboBox
            // 
            this.classComboBox.DataSource = this.classesBindingSource;
            this.classComboBox.DisplayMember = "ClassName";
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.ItemHeight = 23;
            this.classComboBox.Location = new System.Drawing.Point(0, 34);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(179, 29);
            this.classComboBox.TabIndex = 2;
            this.classComboBox.UseSelectable = true;
            this.classComboBox.ValueMember = "ClassID";
            this.classComboBox.SelectedIndexChanged += new System.EventHandler(this.classComboBox_SelectedIndexChanged);
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.attendanceDBLocalDataSetBindingSource;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.valuesReportsButton);
            this.metroTabPage2.Controls.Add(this.dateReportsLabel);
            this.metroTabPage2.Controls.Add(this.classReportsLabel);
            this.metroTabPage2.Controls.Add(this.dateTimePickerReports);
            this.metroTabPage2.Controls.Add(this.classReportsComboBox);
            this.metroTabPage2.Controls.Add(this.reportsListView);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(752, 328);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Reports";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // valuesReportsButton
            // 
            this.valuesReportsButton.Location = new System.Drawing.Point(431, 32);
            this.valuesReportsButton.Name = "valuesReportsButton";
            this.valuesReportsButton.Size = new System.Drawing.Size(75, 23);
            this.valuesReportsButton.TabIndex = 16;
            this.valuesReportsButton.Text = "Get Values";
            this.valuesReportsButton.UseSelectable = true;
            this.valuesReportsButton.Click += new System.EventHandler(this.valuesReportsButton_Click);
            // 
            // dateReportsLabel
            // 
            this.dateReportsLabel.AutoSize = true;
            this.dateReportsLabel.Location = new System.Drawing.Point(207, 13);
            this.dateReportsLabel.Name = "dateReportsLabel";
            this.dateReportsLabel.Size = new System.Drawing.Size(77, 19);
            this.dateReportsLabel.TabIndex = 15;
            this.dateReportsLabel.Text = "Select Date:";
            // 
            // classReportsLabel
            // 
            this.classReportsLabel.AutoSize = true;
            this.classReportsLabel.Location = new System.Drawing.Point(0, 13);
            this.classReportsLabel.Name = "classReportsLabel";
            this.classReportsLabel.Size = new System.Drawing.Size(79, 19);
            this.classReportsLabel.TabIndex = 14;
            this.classReportsLabel.Text = "Select Class:";
            // 
            // dateTimePickerReports
            // 
            this.dateTimePickerReports.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerReports.Location = new System.Drawing.Point(207, 35);
            this.dateTimePickerReports.Name = "dateTimePickerReports";
            this.dateTimePickerReports.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReports.TabIndex = 13;
            this.dateTimePickerReports.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // classReportsComboBox
            // 
            this.classReportsComboBox.DataSource = this.classesBindingSource;
            this.classReportsComboBox.DisplayMember = "ClassName";
            this.classReportsComboBox.FormattingEnabled = true;
            this.classReportsComboBox.ItemHeight = 23;
            this.classReportsComboBox.Location = new System.Drawing.Point(0, 35);
            this.classReportsComboBox.Name = "classReportsComboBox";
            this.classReportsComboBox.Size = new System.Drawing.Size(179, 29);
            this.classReportsComboBox.TabIndex = 12;
            this.classReportsComboBox.UseSelectable = true;
            this.classReportsComboBox.ValueMember = "ClassID";
            // 
            // reportsListView
            // 
            this.reportsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.reportsListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.reportsListView.FullRowSelect = true;
            this.reportsListView.Location = new System.Drawing.Point(4, 77);
            this.reportsListView.Name = "reportsListView";
            this.reportsListView.OwnerDraw = true;
            this.reportsListView.Size = new System.Drawing.Size(752, 230);
            this.reportsListView.TabIndex = 2;
            this.reportsListView.UseCompatibleStateImageBehavior = false;
            this.reportsListView.UseSelectable = true;
            this.reportsListView.View = System.Windows.Forms.View.Details;
            this.reportsListView.SelectedIndexChanged += new System.EventHandler(this.reportsListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Student";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Presence";
            this.columnHeader2.Width = 134;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Abscence";
            this.columnHeader3.Width = 136;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Late";
            this.columnHeader4.Width = 124;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Excused";
            this.columnHeader5.Width = 126;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userNameStatusLabel,
            this.statLabelUserName,
            this.toolStripStatusLabel1,
            this.statLabelUser});
            this.statusStrip1.Location = new System.Drawing.Point(20, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(760, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // userNameStatusLabel
            // 
            this.userNameStatusLabel.Name = "userNameStatusLabel";
            this.userNameStatusLabel.Size = new System.Drawing.Size(68, 17);
            this.userNameStatusLabel.Text = "User Name:";
            // 
            // statLabelUserName
            // 
            this.statLabelUserName.Name = "statLabelUserName";
            this.statLabelUserName.Size = new System.Drawing.Size(15, 17);
            this.statLabelUserName.Text = "~";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "User ID:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // statLabelUser
            // 
            this.statLabelUser.Name = "statLabelUser";
            this.statLabelUser.Size = new System.Drawing.Size(15, 17);
            this.statLabelUser.Text = "~";
            this.statLabelUser.Click += new System.EventHandler(this.statLabelUser_Click);
            // 
            // attendanceDBLocalDataSetBindingSource1
            // 
            this.attendanceDBLocalDataSetBindingSource1.DataSource = this.attendanceDBLocalDataSet;
            this.attendanceDBLocalDataSetBindingSource1.Position = 0;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.attendanceDBLocalDataSetBindingSource;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // recordsTableAdapter
            // 
            this.recordsTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.attendanceTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Attendance System";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.attendanceTabs.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDBLocalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDBLocalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDBLocalDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl attendanceTabs;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private MetroFramework.Controls.MetroComboBox classComboBox;
        private MetroFramework.Controls.MetroButton addStudentsButton;
        private MetroFramework.Controls.MetroButton addClassButton;
        private MetroFramework.Controls.MetroButton clearButton;
        private MetroFramework.Controls.MetroButton saveButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statLabelUser;
        private System.Windows.Forms.BindingSource attendanceDBLocalDataSetBindingSource1;
        private AttendanceDBLocalDataSet attendanceDBLocalDataSet;
        private System.Windows.Forms.BindingSource attendanceDBLocalDataSetBindingSource;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private AttendanceDBLocalDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private MetroFramework.Controls.MetroButton getValuesButton;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private AttendanceDBLocalDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource recordsBindingSource;
        private AttendanceDBLocalDataSetTableAdapters.RecordsTableAdapter recordsTableAdapter;
        private MetroFramework.Controls.MetroListView reportsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MetroFramework.Controls.MetroButton valuesReportsButton;
        private MetroFramework.Controls.MetroLabel dateReportsLabel;
        private MetroFramework.Controls.MetroLabel classReportsLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerReports;
        private MetroFramework.Controls.MetroComboBox classReportsComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private MetroFramework.Controls.MetroButton registerButton;
        private System.Windows.Forms.ToolStripStatusLabel userNameStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel statLabelUserName;
    }
}

