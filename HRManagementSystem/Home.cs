using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void recruitmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recruitment obj = new Recruitment();
            obj.ShowDialog();
        }

        private void applicantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Applicant obj1 = new Applicant();
            obj1.ShowDialog();
        }

        private void recruiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recruiter obj3 = new Recruiter();
            obj3.ShowDialog();
        }

        private void testTimingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestTiming obj4 = new TestTiming();
            obj4.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
