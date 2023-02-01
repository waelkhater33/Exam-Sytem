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
  
    public partial class TrackUpdateForm : Form
    {
        Track model = new Track();  

        public TrackUpdateForm()
        {
            InitializeComponent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                using (Context db = new Context())
                {
                    model.track_id = int.Parse(txtId.Text);
                    var brn = db.Tracks.Where(u => u.track_id == model.track_id).FirstOrDefault();
                    brn.track_name = txtName.Text;
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

