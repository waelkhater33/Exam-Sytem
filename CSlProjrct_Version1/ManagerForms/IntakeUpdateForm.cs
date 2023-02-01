using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CSlProjrct_Version1
{
    public partial class IntakeUpdateForm : Form
    {
        Intake model = new Intake();
        public IntakeUpdateForm()
        {
            InitializeComponent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                using (Context db = new Context())
                {
                    model.intake_id = int.Parse(txtId.Text);
                    var intk = db.Intakes.Where(u => u.intake_id == model.intake_id).FirstOrDefault();
                    intk.intake_number = int.Parse(txtNumber.Text);
                    db.SaveChanges();


                }
                MessageBox.Show("Data is updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
