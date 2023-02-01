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
    public partial class CourseUpdateForm : Form
    {
        Course model = new Course();
        public CourseUpdateForm()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                model.course_id = int.Parse(txtId.Text);
                var crs = db.Courses.Where(u => u.course_id == model.course_id).FirstOrDefault();
                crs.course_name=txtName.Text;
                crs.min_deg = int.Parse(txtMin.Text);
                crs.max_deg = int.Parse(txtMax.Text);
                crs.instructor_id = int.Parse(txtInsId.Text);
                db.SaveChanges();


            }
            MessageBox.Show("Data is updated");
        }
    }
}
