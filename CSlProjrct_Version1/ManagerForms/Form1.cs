using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSlProjrct_Version1
{
    
    public partial class Form1 : Form
    {
        Context ctx = new Context();
        public int Manager_id { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainUserControl1.Hide();
            var mngr = ctx.Instructors
              .Where(s =>  s.instructor_id == Manager_id)//manageID
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
            label4.Text = mngr.instructor_l_n ;
            label6.Text = Manager_id.ToString();
            label10.Text = mngr.userName;
            label12.Text = mngr.Password;
            label16.Text = mngr.adress;
            label26.Text = mngr.phone;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainUserControl1.Show();
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
          Form_logIn frm=new Form_logIn();
            frm.Show();
            this.Hide();
        }
    }
}
