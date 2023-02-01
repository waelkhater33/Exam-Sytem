using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSlProjrct_Version1
{
    public partial class UpdatingTextQ : Form
    {
        public UpdatingTextQ()
        {
            InitializeComponent();
        }

        private void btnUpdateTextQ_Click(object sender, EventArgs e)
        {

            try
            {


                Context con = new Context();
                int _id = Convert.ToInt32(txtUpdateByIdQ.Text);


               QuestionstText des = con.QuestionstTexts.Where(y => y.question_id == _id).FirstOrDefault();

                des.question_des = txtUpdateDesQ.Text;
                des.answer = txtUpdateAnswQ.Text;
                

                con.Entry(des).State = EntityState.Modified;



                con.SaveChanges();
                MessageBox.Show("Data successfully Updated in database");

            }



            catch (Exception E)
            {
                MessageBox.Show("Data Not Upadated in database");

            }
        }

        private void UpdatingTextQ_Load(object sender, EventArgs e)
        {

        }
    }
}
