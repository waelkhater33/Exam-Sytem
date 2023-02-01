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
    public partial class TrackInsertForm : Form
    {
        Track model = new Track();
        public TrackInsertForm()
        {
            InitializeComponent();
        }

        private void btn_InsertByName_Click(object sender, EventArgs e)
        {
            model.track_name = txtName.Text;
            using (Context db = new Context())
            {
                db.Tracks.Add(model);
                db.SaveChanges();
            }

            MessageBox.Show("Saved");
        }
    }
}
