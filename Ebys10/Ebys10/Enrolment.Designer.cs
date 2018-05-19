namespace Ebys10
{
    partial class Enrolment
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
            this.listBoxCourses1 = new System.Windows.Forms.ListBox();
            this.selectbtn = new System.Windows.Forms.Button();
            this.choosenCourseslist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxCourses1
            // 
            this.listBoxCourses1.FormattingEnabled = true;
            this.listBoxCourses1.Location = new System.Drawing.Point(12, 12);
            this.listBoxCourses1.Name = "listBoxCourses1";
            this.listBoxCourses1.Size = new System.Drawing.Size(197, 212);
            this.listBoxCourses1.TabIndex = 4;
            // 
            // selectbtn
            // 
            this.selectbtn.Location = new System.Drawing.Point(215, 94);
            this.selectbtn.Name = "selectbtn";
            this.selectbtn.Size = new System.Drawing.Size(120, 37);
            this.selectbtn.TabIndex = 5;
            this.selectbtn.Text = "Select";
            this.selectbtn.UseVisualStyleBackColor = true;
            this.selectbtn.Click += new System.EventHandler(this.selectbtn_Click);
            // 
            // choosenCourseslist
            // 
            this.choosenCourseslist.FormattingEnabled = true;
            this.choosenCourseslist.Location = new System.Drawing.Point(341, 11);
            this.choosenCourseslist.Name = "choosenCourseslist";
            this.choosenCourseslist.Size = new System.Drawing.Size(151, 212);
            this.choosenCourseslist.TabIndex = 6;
            // 
            // Enrolment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 235);
            this.Controls.Add(this.choosenCourseslist);
            this.Controls.Add(this.selectbtn);
            this.Controls.Add(this.listBoxCourses1);
            this.Name = "Enrolment";
            this.Text = "Enrolment";
            this.Load += new System.EventHandler(this.Enrolment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listBoxCourses1;
        private System.Windows.Forms.Button selectbtn;
        private System.Windows.Forms.ListBox choosenCourseslist;
    }
}