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
    public partial class InstructorDeleteForm : Form
    {
        public InstructorDeleteForm()
        {
            InitializeComponent();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                Context db = new Context();
                var txt = int.Parse(txt_del.Text);
                var ins = db.Instructors.Where(u => u.instructor_id == txt).FirstOrDefault();
                db.Instructors.Remove(ins);
                db.SaveChanges();
                MessageBox.Show("Data deleted");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Can't delete because it's a foreign key in other table.. {ex.Message}");
            }
        }
    }
}
