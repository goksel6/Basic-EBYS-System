namespace Ebys10
{
    partial class Login
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
            this.logınbtn = new System.Windows.Forms.Button();
            this.StudentId = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.StudentPass = new System.Windows.Forms.Label();
            this.TeacherLabel = new System.Windows.Forms.Label();
            this.TeacherPass = new System.Windows.Forms.Label();
            this.TeacherId = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.MentorLabel = new System.Windows.Forms.Label();
            this.MentorPass = new System.Windows.Forms.Label();
            this.MentorId = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logınbtn
            // 
            this.logınbtn.Location = new System.Drawing.Point(242, 78);
            this.logınbtn.Name = "logınbtn";
            this.logınbtn.Size = new System.Drawing.Size(156, 75);
            this.logınbtn.TabIndex = 0;
            this.logınbtn.Text = "LOGIN";
            this.logınbtn.UseVisualStyleBackColor = true;
            this.logınbtn.Click += new System.EventHandler(this.logınbtn_Click);
            // 
            // StudentId
            // 
            this.StudentId.Location = new System.Drawing.Point(110, 17);
            this.StudentId.Name = "StudentId";
            this.StudentId.Size = new System.Drawing.Size(100, 20);
            this.StudentId.TabIndex = 1;
            this.StudentId.Text = "-";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "-";
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Location = new System.Drawing.Point(48, 17);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(56, 13);
            this.StudentLabel.TabIndex = 3;
            this.StudentLabel.Text = "Student Id";
            // 
            // StudentPass
            // 
            this.StudentPass.AutoSize = true;
            this.StudentPass.Location = new System.Drawing.Point(48, 46);
            this.StudentPass.Name = "StudentPass";
            this.StudentPass.Size = new System.Drawing.Size(53, 13);
            this.StudentPass.TabIndex = 4;
            this.StudentPass.Text = "Password";
            // 
            // TeacherLabel
            // 
            this.TeacherLabel.AutoSize = true;
            this.TeacherLabel.Location = new System.Drawing.Point(233, 17);
            this.TeacherLabel.Name = "TeacherLabel";
            this.TeacherLabel.Size = new System.Drawing.Size(59, 13);
            this.TeacherLabel.TabIndex = 5;
            this.TeacherLabel.Text = "Teacher Id";
            // 
            // TeacherPass
            // 
            this.TeacherPass.AutoSize = true;
            this.TeacherPass.Location = new System.Drawing.Point(239, 46);
            this.TeacherPass.Name = "TeacherPass";
            this.TeacherPass.Size = new System.Drawing.Size(53, 13);
            this.TeacherPass.TabIndex = 6;
            this.TeacherPass.Text = "Password";
            // 
            // TeacherId
            // 
            this.TeacherId.Location = new System.Drawing.Point(298, 12);
            this.TeacherId.Name = "TeacherId";
            this.TeacherId.Size = new System.Drawing.Size(100, 20);
            this.TeacherId.TabIndex = 7;
            this.TeacherId.Text = "-";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(298, 43);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "-";
            // 
            // MentorLabel
            // 
            this.MentorLabel.AutoSize = true;
            this.MentorLabel.Location = new System.Drawing.Point(47, 88);
            this.MentorLabel.Name = "MentorLabel";
            this.MentorLabel.Size = new System.Drawing.Size(52, 13);
            this.MentorLabel.TabIndex = 9;
            this.MentorLabel.Text = "Mentor Id";
            // 
            // MentorPass
            // 
            this.MentorPass.AutoSize = true;
            this.MentorPass.Location = new System.Drawing.Point(47, 123);
            this.MentorPass.Name = "MentorPass";
            this.MentorPass.Size = new System.Drawing.Size(53, 13);
            this.MentorPass.TabIndex = 10;
            this.MentorPass.Text = "Password";
            // 
            // MentorId
            // 
            this.MentorId.Location = new System.Drawing.Point(110, 85);
            this.MentorId.Name = "MentorId";
            this.MentorId.Size = new System.Drawing.Size(100, 20);
            this.MentorId.TabIndex = 11;
            this.MentorId.Text = "-";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(110, 120);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 12;
            this.textBox6.Text = "-";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 238);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.MentorId);
            this.Controls.Add(this.MentorPass);
            this.Controls.Add(this.MentorLabel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.TeacherId);
            this.Controls.Add(this.TeacherPass);
            this.Controls.Add(this.TeacherLabel);
            this.Controls.Add(this.StudentPass);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.StudentId);
            this.Controls.Add(this.logınbtn);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logınbtn;
        private System.Windows.Forms.TextBox StudentId;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Label StudentPass;
        private System.Windows.Forms.Label TeacherLabel;
        private System.Windows.Forms.Label TeacherPass;
        private System.Windows.Forms.TextBox TeacherId;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label MentorLabel;
        private System.Windows.Forms.Label MentorPass;
        private System.Windows.Forms.TextBox MentorId;
        private System.Windows.Forms.TextBox textBox6;
    }
}