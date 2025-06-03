namespace AttendanceSystem
{
    partial class AddClassForm
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
            this.classNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.acceptClassButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // classNameTextBox
            // 
            // 
            // 
            // 
            this.classNameTextBox.CustomButton.Image = null;
            this.classNameTextBox.CustomButton.Location = new System.Drawing.Point(305, 1);
            this.classNameTextBox.CustomButton.Name = "";
            this.classNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.classNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.classNameTextBox.CustomButton.TabIndex = 1;
            this.classNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.classNameTextBox.CustomButton.UseSelectable = true;
            this.classNameTextBox.CustomButton.Visible = false;
            this.classNameTextBox.Lines = new string[0];
            this.classNameTextBox.Location = new System.Drawing.Point(19, 48);
            this.classNameTextBox.MaxLength = 32767;
            this.classNameTextBox.Name = "classNameTextBox";
            this.classNameTextBox.PasswordChar = '\0';
            this.classNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.classNameTextBox.SelectedText = "";
            this.classNameTextBox.SelectionLength = 0;
            this.classNameTextBox.SelectionStart = 0;
            this.classNameTextBox.ShortcutsEnabled = true;
            this.classNameTextBox.Size = new System.Drawing.Size(327, 23);
            this.classNameTextBox.TabIndex = 0;
            this.classNameTextBox.UseSelectable = true;
            this.classNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.classNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.classNameTextBox.Click += new System.EventHandler(this.classNameTextBox_Click);
            // 
            // acceptClassButton
            // 
            this.acceptClassButton.Location = new System.Drawing.Point(271, 77);
            this.acceptClassButton.Name = "acceptClassButton";
            this.acceptClassButton.Size = new System.Drawing.Size(75, 23);
            this.acceptClassButton.TabIndex = 1;
            this.acceptClassButton.Text = "Accept";
            this.acceptClassButton.UseSelectable = true;
            this.acceptClassButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.metroLabel1.Location = new System.Drawing.Point(19, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Class Name:";
            // 
            // AddClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 127);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.acceptClassButton);
            this.Controls.Add(this.classNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Class";
            this.Load += new System.EventHandler(this.AddClassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox classNameTextBox;
        private MetroFramework.Controls.MetroButton acceptClassButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}