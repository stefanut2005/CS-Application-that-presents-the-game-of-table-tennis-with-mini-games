using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Duta_Stefan
{
    public partial class FormMozaic : Form
    {
        public FormMozaic()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Width += 100;
            (sender as PictureBox).Height += 100;
            (sender as PictureBox).BringToFront();
            label1.Text = (sender as PictureBox).Tag.ToString();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Width -= 100;
            (sender as PictureBox).Height -= 100;
            label1.Text = string.Empty;
        }

        private void FormMozaic_Load(object sender, EventArgs e)
        {

        }
    }
}
