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
    public partial class TrackDeleteForm : Form
    {
        public TrackDeleteForm()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Context db = new Context();
                var txt = int.Parse(txtId.Text);
                var trck = db.Tracks.Where(u => u.track_id == txt).FirstOrDefault();
                db.Tracks.Remove(trck);
                db.SaveChanges();
                MessageBox.Show("Data deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void btn_DelByName_Click(object sender, EventArgs e)
        {
            try
            {
                Context db = new Context();
                var txt = txtName.Text;
                var trck = db.Tracks.Where(u => u.track_name == txt).FirstOrDefault();
                db.Tracks.Remove(trck);
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
