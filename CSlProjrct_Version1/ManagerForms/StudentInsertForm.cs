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
    public partial class StudentInsertForm : Form
    {
        Student model = new Student();
        public StudentInsertForm()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            model.student_fn = txtFname.Text;
            model.student_ln = txtLname.Text;
            model.adress = txtAdd.Text;
            model.phone = txtPhone.Text;
            model.userName = txtUname.Text;
            model.Password = txtPword.Text;
            model.branch_id = int.Parse(txtBranchId.Text);
            model.intake_id = int.Parse(txtIntakeId.Text);
            model.track_id = int.Parse(txtTrackId.Text);
            model.exam_id= int.Parse(txtExamId.Text);
            model.course_id = int.Parse(txtCoursId.Text);

            using(Context db = new Context())
            {
                db.Students.Add(model);
                db.SaveChanges();
            }

            MessageBox.Show("DAta saved to database");
        }
    }
}
