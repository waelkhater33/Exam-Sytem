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
    public partial class UpatingTandFQ : Form
    {
        public UpatingTandFQ()
        {
            InitializeComponent();
        }

        private void btnUpdateTfQ_Click(object sender, EventArgs e)
        {
            Context con = new Context();


            try
            {



                int _id = Convert.ToInt32(txtUpdateByIDQ.Text);


                QuestionstTF des = con.QuestionstTFs.Where(y => y.question_id == _id).FirstOrDefault();

                des.question_des = txtUpdateDesQ.Text;
                des.answer =  Convert.ToBoolean(TxtUpdateAnswQ.Text);

                con.Entry(des).State = EntityState.Modified;



                con.SaveChanges();
                MessageBox.Show("Data successfully Updated in database");

            }



            catch (Exception E)
            {
                MessageBox.Show("Data Not Upadated in database");

            }

        }
    }
}
