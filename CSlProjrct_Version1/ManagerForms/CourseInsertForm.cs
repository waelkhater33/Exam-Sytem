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
    public partial class CourseInsertForm : Form
    {
        Course model = new Course();
        public CourseInsertForm()
        {
            InitializeComponent();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            model.course_name = txtName.Text;
            model.min_deg = int.Parse(txtMin.Text);
            model.max_deg = int.Parse(txtMax.Text);
            model.instructor_id = int.Parse(txtInst.Text);

            using(Context db = new Context())
            {
                db.Courses.Add(model);
                db.SaveChanges();
            }
            MessageBox.Show("Data saved to database");
        }
    }
}
