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
    public partial class FormAlbumFotoPagini : Form
    {
        public FormAlbumFotoPagini()
        {
            InitializeComponent();
        }

        int imgCrt = 0, nrImg = 5;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            imgCrt--;

            if (imgCrt == 0)

                imgCrt = nrImg;

            Image myimage = new Bitmap(@"Resurse\\Album\\" + Convert.ToString(imgCrt) + @".jpg");
            pictureBox1.BackgroundImage = myimage;

            //pictureBox1.Load("Resources\\AlbumFoto\\" + Convert.ToString(imgCrt) + ".jpg");

            richTextBox1.LoadFile("Resurse\\Album\\" + Convert.ToString(imgCrt) + ".rtf");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            imgCrt++;

            if (imgCrt > nrImg)

                imgCrt = 1;

            Image myimage = new Bitmap(@"Resurse\\Album\\" + Convert.ToString(imgCrt) + @".jpg");
            pictureBox1.BackgroundImage = myimage;
            //pictureBox1.Load("Resources\\AlbumFoto\\" + Convert.ToString(imgCrt) + ".jpg");

            richTextBox1.LoadFile("Resurse\\Album\\" + Convert.ToString(imgCrt) + ".rtf");
        }

        private void FormAlbumFotoPagini_Load(object sender, EventArgs e)
        {
            imgCrt = 1;

            Image myimage = new Bitmap(@"Resurse\\Album\\" + Convert.ToString(imgCrt) + @".jpg");
            pictureBox1.BackgroundImage = myimage;

            richTextBox1.LoadFile("Resurse\\Album\\" + Convert.ToString(imgCrt) + ".rtf");
        }
    }
}
