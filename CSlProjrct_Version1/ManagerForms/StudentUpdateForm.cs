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
    public partial class StudentUpdateForm : Form
    {
        Student model = new Student();
        public StudentUpdateForm()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                model.student_id = int.Parse(txtId.Text);
                var ins = db.Students.Where(u => u.student_id == model.student_id).FirstOrDefault();
                ins.student_fn = txtFname.Text;
                ins.student_ln = txtLname.Text;
                ins.adress = txtAddr.Text;
                ins.phone = txtPhone.Text;
                ins.userName = txtUname.Text;
                ins.Password = txtPword.Text;
                db.SaveChanges();


            }
            MessageBox.Show("Data is updated");
        }
    }
}
