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
    public partial class BranchDeleteForm : Form
    {
        public BranchDeleteForm()
        {
            InitializeComponent();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                Context db = new Context();
                var txt = int.Parse(txtId.Text);
                var ins = db.Branches.Where(u => u.branch_id == txt).FirstOrDefault();
                db.Branches.Remove(ins);
                db.SaveChanges();
                MessageBox.Show("Data deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
