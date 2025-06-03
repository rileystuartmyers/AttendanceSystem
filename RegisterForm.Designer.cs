namespace AttendanceSystem
{
    partial class RegisterForm
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
            this.userTextBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.confirmTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.acceptButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // userTextBox
            // 
            // 
            // 
            // 
            this.userTextBox.CustomButton.Image = null;
            this.userTextBox.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.userTextBox.CustomButton.Name = "";
            this.userTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.userTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userTextBox.CustomButton.TabIndex = 1;
            this.userTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userTextBox.CustomButton.UseSelectable = true;
            this.userTextBox.CustomButton.Visible = false;
            this.userTextBox.Lines = new string[0];
            this.userTextBox.Location = new System.Drawing.Point(34, 43);
            this.userTextBox.MaxLength = 32767;
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.PasswordChar = '\0';
            this.userTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userTextBox.SelectedText = "";
            this.userTextBox.SelectionLength = 0;
            this.userTextBox.SelectionStart = 0;
            this.userTextBox.ShortcutsEnabled = true;
            this.userTextBox.Size = new System.Drawing.Size(162, 23);
            this.userTextBox.TabIndex = 0;
            this.userTextBox.UseSelectable = true;
            this.userTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.userTextBox.Click += new System.EventHandler(this.userTextBox_Click);
            // 
            // passwordTextBox
            // 
            // 
            // 
            // 
            this.passwordTextBox.CustomButton.Image = null;
            this.passwordTextBox.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.passwordTextBox.CustomButton.Name = "";
            this.passwordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextBox.CustomButton.TabIndex = 1;
            this.passwordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextBox.CustomButton.UseSelectable = true;
            this.passwordTextBox.CustomButton.Visible = false;
            this.passwordTextBox.Lines = new string[0];
            this.passwordTextBox.Location = new System.Drawing.Point(34, 103);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(162, 23);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSelectable = true;
            this.passwordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTextBox.Click += new System.EventHandler(this.passwordTextBox_Click);
            // 
            // confirmTextBox
            // 
            // 
            // 
            // 
            this.confirmTextBox.CustomButton.Image = null;
            this.confirmTextBox.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.confirmTextBox.CustomButton.Name = "";
            this.confirmTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.confirmTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.confirmTextBox.CustomButton.TabIndex = 1;
            this.confirmTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.confirmTextBox.CustomButton.UseSelectable = true;
            this.confirmTextBox.CustomButton.Visible = false;
            this.confirmTextBox.Lines = new string[0];
            this.confirmTextBox.Location = new System.Drawing.Point(34, 182);
            this.confirmTextBox.MaxLength = 32767;
            this.confirmTextBox.Name = "confirmTextBox";
            this.confirmTextBox.PasswordChar = '*';
            this.confirmTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirmTextBox.SelectedText = "";
            this.confirmTextBox.SelectionLength = 0;
            this.confirmTextBox.SelectionStart = 0;
            this.confirmTextBox.ShortcutsEnabled = true;
            this.confirmTextBox.Size = new System.Drawing.Size(162, 23);
            this.confirmTextBox.TabIndex = 2;
            this.confirmTextBox.UseSelectable = true;
            this.confirmTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.confirmTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.confirmTextBox.Click += new System.EventHandler(this.confirmTextBox_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(34, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "User Name:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(34, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Password:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(34, 160);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(118, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Confirm Password:";
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(212, 182);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseSelectable = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 229);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.confirmTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox userTextBox;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private MetroFramework.Controls.MetroTextBox confirmTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton acceptButton;
    }
}