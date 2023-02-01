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
    public partial class BranchInsertForm : Form
    {
        Branch model = new Branch();
        public BranchInsertForm()
        {
            InitializeComponent();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {

            model.branch_name = txtName.Text;
            using (Context db = new Context())
            {
                db.Branches.Add(model);
                db.SaveChanges();
            }

            MessageBox.Show("Saved");
        }
    }
}
