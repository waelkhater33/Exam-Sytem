using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Linq;

namespace CSlProjrct_Version1
{
    public partial class InstructorUpdateForm : Form
    {
        Instructor model = new Instructor();

        public InstructorUpdateForm()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //model.instructor_id = int.Parse(txtId.Text);
            //model.instructor_f_n = txtFname.Text;
            using(Context db = new Context())
            {
                model.instructor_id = int.Parse(txtId.Text);
                var ins = db.Instructors.Where(u => u.instructor_id == model.instructor_id).FirstOrDefault();
                ins.instructor_f_n = txtFname.Text;
                ins.instructor_l_n = txtLname.Text;
                ins.email = txtEmail.Text;
                ins.adress = txtAddr.Text;
                ins.phone = txtPhone.Text;
                ins.userName = txtUname.Text;
                ins.Password = txtPword.Text;
                ins.manager_ID = int.Parse (txtPword.Text);
                db.SaveChanges();
                

            }
            MessageBox.Show("Data is updated");
        }
    }
}
