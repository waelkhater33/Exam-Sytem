using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSlProjrct_Version1
{
    public partial class updatingChoices : Form
    {
        public string IQUPdate { set; get; }
       
        public updatingChoices()
        {
            InitializeComponent();
        }

        private void updating_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdatingQ_Click(object sender, EventArgs e)
        {
            Context con = new Context();

           
                try
                {

                    
                    
                        int _id = Convert.ToInt32(txtUpdatinByIdQ.Text);

                   
                    QuestionstChoice des = con.QuestionstChoices.Where(y => y.question_id == _id).FirstOrDefault();

                    des.question_des = txtUpdatingDecQ.Text;
                    des.option1 = txtUpdatingOpt1Q.Text;
                    des.option2 = txtUpdatingOpt2Q.Text;
                    des.option3= txtUpdatingOpt3Q.Text;
                    des.option4 = txtUpdatingOpt4Q.Text;
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
    }
}
