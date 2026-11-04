using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMRA_SICI3029
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            LeftManLabel.Visible = false;
            RightManLabel.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PilatesStaffButton_Click(object sender, EventArgs e)
        {
            LeftManLabel.Visible = true;
            RightManLabel.Visible = false;


            pictureBox1.Image = Properties.Resources.LeftMan;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void KarateStaffButton_Click(object sender, EventArgs e)
        {
            

           RightManLabel.Visible = true;
            LeftManLabel.Visible = false;

            pictureBox1.Image = Properties.Resources.RightMan;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
