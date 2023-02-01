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
    public partial class IntakeInsertForm : Form
    {
        Intake model = new Intake();
        public IntakeInsertForm()
        {
            InitializeComponent();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            model.intake_number =int .Parse (txtIntakeNum.Text);
            using (Context db = new Context())
            {
                db.Intakes.Add(model);
                db.SaveChanges();
            }

            MessageBox.Show("Saved");
        }
    }
}
