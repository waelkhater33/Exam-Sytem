using CSlProjrct_Version1.Instructor_create_ExamForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSlProjrct_Version1
{
    public partial class EditAllQuetions : Form
    {
        public EditAllQuetions()
        {
            InitializeComponent();
        }

        private void ConnnetToAdd_Click(object sender, EventArgs e)
        {

            if(SelectedItem.Text=="Choices")
            {
                AddChoiceQ c = new AddChoiceQ();
                c.Show();

            }
            else if (SelectedItem.Text == "Text")
            {
                AddTextQ t = new AddTextQ();
                t.Show();
            }


            else
            {
                AddTAndFQ tf = new AddTAndFQ();
                tf.Show();

            }
           


            }

        public void comBoxAddSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            SelectedItem.Text = comBoxAddSelect.Text;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Deleting del = new Deleting();
            del.IQdelete = SelectedItem.Text;
            del.Show();
            
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SelectedItem.Text == "Choices")
            {
                updatingChoices upd = new updatingChoices();
                upd.Show();
            }
            else if (SelectedItem.Text == "Text")
            {
                UpdatingTextQ upt = new UpdatingTextQ();
                upt.Show();
            }
            else
            {
                UpatingTandFQ uptf = new UpatingTandFQ();
                uptf.Show();
            }


        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        private void EditAllQuetions_Load(object sender, EventArgs e)
        {

        }

        private void btn_backtoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
