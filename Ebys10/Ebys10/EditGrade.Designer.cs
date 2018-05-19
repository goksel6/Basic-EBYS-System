namespace Ebys10
{
    partial class EditGrade
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
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.gradetxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.Location = new System.Drawing.Point(12, 12);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(129, 173);
            this.listBoxCourses.TabIndex = 3;
            this.listBoxCourses.Click += new System.EventHandler(this.listBoxCourses_Click);
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.Location = new System.Drawing.Point(147, 12);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(120, 108);
            this.listBoxStudents.TabIndex = 4;
            this.listBoxStudents.Click += new System.EventHandler(this.listBoxStudents_Click);
            // 
            // gradetxt
            // 
            this.gradetxt.Location = new System.Drawing.Point(147, 126);
            this.gradetxt.Name = "gradetxt";
            this.gradetxt.Size = new System.Drawing.Size(120, 20);
            this.gradetxt.TabIndex = 5;
            this.gradetxt.Text = "gradetxt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 210);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gradetxt);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.listBoxCourses);
            this.Name = "EditGrade";
            this.Text = "EditGrade";
            this.Load += new System.EventHandler(this.EditGrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.TextBox gradetxt;
        private System.Windows.Forms.Button button1;
    }
}

