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
    public partial class IntakeDaleteForm : Form
    {
        public IntakeDaleteForm()
        {
            InitializeComponent();
        }

        private void btn_DelByNum_Click(object sender, EventArgs e)
        {
            try
            {
                Context db = new Context();
                var txt = int.Parse(txtId.Text);
                var intk = db.Intakes.Where(u => u.intake_id == txt).FirstOrDefault();
                db.Intakes.Remove(intk);
                db.SaveChanges();
                MessageBox.Show("Data deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Can't delete because it's a foreign key in other table.. {ex.Message}");
            }
        }

        private void btn_DelByName_Click(object sender, EventArgs e)
        {
            try
            {
                Context db = new Context();
                var txt =int.Parse( txtNumber.Text);
                var intk = db.Intakes.Where(u => u.intake_number == txt).FirstOrDefault();
                db.Intakes.Remove(intk);
                db.SaveChanges();
                MessageBox.Show("Data deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Can't delete because it's a foreign key in other table.. {ex.Message}");
            }
        }
    }
}
