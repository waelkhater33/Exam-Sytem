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
    public partial class Deleting : Form
    {
        public string IQdelete{ set; get; }
        public Deleting()
        {
            InitializeComponent();
           
        }

        private void btnDeleteQ_Click(object sender, EventArgs e)
        {
            Context con = new Context();

            if (IQdelete == "Choices")
            {
                try
                {
                 
                    QuestionstChoice ch= new QuestionstChoice (){ question_id = Convert.ToInt32(txtDeleteByidQ.Text) };

                    con.QuestionstChoices.Attach(ch);
                    con.QuestionstChoices.Remove(ch);
                    
                    con.SaveChanges();
                    MessageBox.Show("Data has  Deleted in database");
                }



                catch (Exception E)
                {
                    MessageBox.Show("Data Not  Deleted in database");

                }
            }
            else if (IQdelete == "Text")
            {
                try
                {
                   
                   QuestionstText tx = new QuestionstText() { question_id = Convert.ToInt32(txtDeleteByidQ.Text) };
                    con.QuestionstTexts.Attach(tx);
                    con. QuestionstTexts .Remove(tx);
                    con.SaveChanges();
                    MessageBox.Show("Data has  Deleted in database");
                }



                catch (Exception E)
                {
                    MessageBox.Show("Data Not  Deleted in database");

                }
            }
            else
            {
                  try
                    {
                       
                        QuestionstTF tf = new QuestionstTF() { question_id = Convert.ToInt32(txtDeleteByidQ.Text) };
                        con.QuestionstTFs.Attach(tf);
                        con.QuestionstTFs.Remove(tf);
                        con.SaveChanges();
                        MessageBox.Show("Data has Deleted in database");
                    }



                    catch (Exception E)
                    {
                        MessageBox.Show("Data Not  Deleted in database");

                    }
                }

            }



        

        private void Deleting_Load(object sender, EventArgs e)
        {
            
        }
    }
}
