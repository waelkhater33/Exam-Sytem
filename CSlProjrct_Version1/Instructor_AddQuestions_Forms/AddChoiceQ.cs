using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSlProjrct_Version1
{
    public partial class AddChoiceQ : Form
    {
        public AddChoiceQ()
        {
            InitializeComponent();
        }

        private void btnAddChoiceQ_Click(object sender, EventArgs e)
        {
            try
            {
                Context con = new Context();
                QuestionstChoice ch = new QuestionstChoice()
                {

                    question_des = txtDesChoiceQ.Text,
                    option1 = txtOPT1ChoiceQ.Text,
                    option2 = txtOPT2ChoiceQ.Text,
                    option3 = txtOPT3ChoiceQ.Text,
                    option4 = txtOPT4ChoiceQ.Text,
                    answer=txtAddAnswQ.Text,
                     
                    course_id = Convert.ToInt32(txtCrsIdChoiceQ.Text)
                };

                
                con.QuestionstChoices.Add(ch);
                con.SaveChanges();
                 MessageBox.Show("Data saved succssfully in database");
                    
                
            }
            catch( Exception E)
            {
                MessageBox.Show("Data Not saved in database");

            }

        }

        private void AddChoiceQ_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
