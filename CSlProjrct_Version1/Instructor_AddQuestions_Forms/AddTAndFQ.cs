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
    public partial class AddTAndFQ : Form
    {
        public AddTAndFQ()
        {
            InitializeComponent();
        }

        private void btnAddTfQ_Click(object sender, EventArgs e)
        {
            try
            {
                Context con = new Context();
                QuestionstTF tf = new QuestionstTF()

                {
                    question_des = txtDesTfQ.Text,
                    answer =  Convert.ToBoolean( txtAnswTfQ.Text),
                    course_id= Convert.ToInt32(txtCrsIdTfQ.Text)

                      


                };
                con.QuestionstTFs.Add(tf);
                con.SaveChanges();
                MessageBox.Show("Data has saved in database");
             
            
            }
            catch(Exception E)
            {
                MessageBox.Show("Data Not saved in database");

            }




        }
    }
}
