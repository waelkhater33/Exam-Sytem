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
    public partial class AddTextQ : Form
    {
        Context con = new Context();
        public AddTextQ()
        {
            InitializeComponent();
        }

        private void btnAddTextQ_Click(object sender, EventArgs e)
        {
            
            try
            {
                QuestionstText tx = new QuestionstText()
                {
                    question_des = txtDesAddQ.Text,
                    answer = txtAnswAddQ.Text,
                    course_id = Convert.ToInt32(txtCsrIDAddQ.Text)


                };
                con.QuestionstTexts.Add(tx);
                con.SaveChanges();
                MessageBox.Show("Data saved succefully in database");
            }
            catch (Exception E)
            {
                MessageBox.Show("Data Not saved in database");

            }

        }

        private void AddTextQ_Load(object sender, EventArgs e)
        {

        }
    }
    }
