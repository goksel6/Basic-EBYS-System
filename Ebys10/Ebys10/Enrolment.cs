using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ebys10
{
    public partial class Enrolment : Form
    {
        string studentId;
        public Enrolment(string sId)
        {
            studentId = sId;
            InitializeComponent();
        }

        private void Enrolment_Load(object sender, EventArgs e)
        {
            STUDENT s = new STUDENT();
            List<string> a = new List<string>();
            a = s.getSemesterCourse();
            foreach (string m in a)
            {
                listBoxCourses1.Items.Add(m);
            }
        }
        private void listBoxCourses1_Click(object sender, EventArgs e)
        {


        }

        private void selectbtn_Click(object sender, EventArgs e)
        {
            STUDENT s = new STUDENT();
           
            s.choosenCourses.Add(listBoxCourses1.SelectedItem.ToString());
            choosenCourseslist.Items.Add(listBoxCourses1.SelectedItem.ToString());
         
           
        }
    }
}
