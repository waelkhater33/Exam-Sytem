using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSlProjrct_Version1
{
    public partial class InstructorInsertForm : Form
    {
        Instructor model = new Instructor();
        public InstructorInsertForm()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            model.instructor_f_n = txt_fname.Text;
            model.instructor_l_n = txt_lname.Text;
            model.email = txt_email.Text;
            model.adress = txt_add.Text;
            model.phone=txt_phone.Text;
            model.userName=txt_username.Text;
            model.Password = txt_psssword.Text;
            model.manager_ID = int.Parse(txt_mgrId.Text);
            using (Context db = new Context())
            {
                db.Instructors.Add(model);
                db.SaveChanges();
            }
           
            MessageBox.Show("Saved");
        }
    }
}
