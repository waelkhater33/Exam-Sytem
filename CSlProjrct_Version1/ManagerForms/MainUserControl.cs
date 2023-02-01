using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSlProjrct_Version1
{
    public partial class MainUserControl : UserControl
    {
        public MainUserControl()
        {
            InitializeComponent();
        }

        private void MainUserControl_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            BranchDeleteForm frm = new BranchDeleteForm();
            frm.Show();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            InstructorInsertForm frm = new InstructorInsertForm();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentInsertForm frm = new StudentInsertForm();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CourseInsertForm frm = new CourseInsertForm();
            frm.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            InstructorUpdateForm frm = new InstructorUpdateForm();
            frm.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            InstructorDeleteForm frm = new InstructorDeleteForm();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentUpdateForm frm = new StudentUpdateForm();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BranchInsertForm frm = new BranchInsertForm();
            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TrackInsertForm frm = new TrackInsertForm();
            frm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            IntakeInsertForm frm = new IntakeInsertForm();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CourseUpdateForm frm = new CourseUpdateForm();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BranchUpdateForm frm = new BranchUpdateForm();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TrackUpdateForm frm = new TrackUpdateForm();
            frm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            IntakeUpdateForm frm = new IntakeUpdateForm();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDeleteForm frm = new StudentDeleteForm();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CourseDeleteForm frm = new CourseDeleteForm();
            frm.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            TrackDeleteForm frm = new TrackDeleteForm();
            frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            IntakeDaleteForm frm = new IntakeDaleteForm();
            frm.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AddInstructorToCourse frm = new AddInstructorToCourse();
            frm.Show();
        }
    }
}
