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
    public partial class BranchUpdateForm : Form
    {
        Branch model = new Branch();
        public BranchUpdateForm()
        {
            InitializeComponent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                using (Context db = new Context())
                {
                    model.branch_id = int.Parse(txtId.Text);
                    var brn = db.Branches.Where(u => u.branch_id == model.branch_id).FirstOrDefault();
                    brn.branch_name = txtName.Text;
                    db.SaveChanges();


                }
                MessageBox.Show("Data is updated");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
