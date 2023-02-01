using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSlProjrct_Version1.Instructor_create_ExamForms
{
    public partial class Instructor_dashBooard : Form
    {
        Context ctx =new Context();
        public int Instructor_id { get; set; }
        public Instructor_dashBooard()
        {
            InitializeComponent();
        }

        private void Instructor_dashBooard_Load(object sender, EventArgs e)
        {
            var mngr = ctx.Instructors
            .Where(s => s.instructor_id == Instructor_id)//manageID
            .Select(s => new
            {
                s.instructor_f_n,
                s.instructor_l_n,
                s.adress,
                s.userName,
                s.Password,
                s.phone,
               
            }).FirstOrDefault();

            label2.Text = mngr.instructor_f_n;
            label4.Text = mngr.instructor_l_n;
            label6.Text = Instructor_id.ToString();

            label10.Text = mngr.userName;
            label12.Text = mngr.Password;
            label16.Text = mngr.adress;
            label26.Text = mngr.phone;
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            Form_logIn frm = new Form_logIn();
            frm.Show();
          
        }

        private void btn_AddQuestiom_Click(object sender, EventArgs e)
        {
            EditAllQuetions frm=new EditAllQuetions();
            frm.Show();
           // this.Hide();
        }

        private void btn_createExam_Click(object sender, EventArgs e)
        {
            instractorform frm = new instractorform();
            frm.Instructor_id = Instructor_id;
            frm.Show();
            this.Hide();
        }

        private void btn_SignStudentToExam_Click(object sender, EventArgs e)
        {

        }

        private void btn_student_Result_Click(object sender, EventArgs e)
        {
            Form_AllStudents_Result frm = new Form_AllStudents_Result();
            frm.Show();
        }
    }
}
