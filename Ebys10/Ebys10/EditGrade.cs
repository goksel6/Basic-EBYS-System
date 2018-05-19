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
    public partial class EditGrade : Form
    {
        string teacherId;
        public EditGrade(string TeacherId)
        {
            teacherId = TeacherId;
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
           
           
        }

        private void listBoxCourses_Click(object sender, EventArgs e)
        {
            GIVENCOURSES g = new GIVENCOURSES();
            List<string> a = new List<string>();
            a = g.getStudents(listBoxCourses.SelectedItem.ToString());
            foreach(string m in a)
            {
                listBoxStudents.Items.Add(m);
            }

       }

        private void listBoxStudents_Click(object sender, EventArgs e)
        {

         }

        private void button1_Click(object sender, EventArgs e)
        {
            TAKENCOURSES t = new TAKENCOURSES();
            int a = Int32.Parse(gradetxt.Text);
            t.saveGrade(listBoxCourses.SelectedItem.ToString(), listBoxStudents.SelectedItem.ToString(), a);
            MessageBox.Show("Not Başarıyla Girildi.");
        }

        private void EditGrade_Load(object sender, EventArgs e)
        {
            List<string> a = new List<string>();
            TEACHER t = new TEACHER();
            a = t.getCourse(teacherId);
            foreach (string m in a)
            {
                listBoxCourses.Items.Add(m);
            }
        }
    }
}
