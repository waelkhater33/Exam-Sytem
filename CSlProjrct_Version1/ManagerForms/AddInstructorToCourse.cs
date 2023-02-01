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
    public partial class AddInstructorToCourse : Form
    {
        Instructor model = new Instructor();
        Course model2 = new Course();
        public AddInstructorToCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                model.instructor_f_n = txtFname.Text;
                model.instructor_l_n = txtLname.Text;
                // model.instructor_id = int.Parse(txtId.Text);
                model2.instructor_id = model.instructor_id;
                model2.course_name = txtCourseName.Text;

                using (Context db = new Context())
                {
                    db.Instructors.Add(model);
                    db.Courses.Add(model2);
                    db.SaveChanges();

                    MessageBox.Show("Data added");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
