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
    public partial class CourseDeleteForm : Form
    {
        Course model = new Course();
        public CourseDeleteForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete2_Click(object sender, EventArgs e)
        {
            try
            {
                Context db = new Context();
                var txt = txtName.Text;
                var crs = db.Courses.Where(u => u.course_name == txt).FirstOrDefault();
                db.Courses.Remove(crs);
                db.SaveChanges();
                MessageBox.Show("Data deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Context db = new Context();
                var txt = int.Parse(txtId.Text);
                var crs = db.Courses.Where(u => u.course_id == txt).FirstOrDefault();
                db.Courses.Remove(crs);
                db.SaveChanges();
                MessageBox.Show("Data deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CourseDeleteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
