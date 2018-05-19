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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void logınbtn_Click(object sender, EventArgs e)
        {
            if (StudentId.Text!="-")
            {
                Enrolment en = new Enrolment(StudentId.Text);
                en.Show();

            }
            if (TeacherId.Text != "-" )
            {
                EditGrade eg = new EditGrade(TeacherId.Text);
                eg.Show();

            }
            if (MentorId.Text !="-")
            {

            }
        }
    }
}
