using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Duta_Stefan
{
    public partial class FormMemory : Form
    {
        public FormMemory()
        {
            InitializeComponent();
        }

        private void FormMemory_Load(object sender, EventArgs e)
        {
            int nrPerechi = 5, i, tag;
            int[] perechi = new int[nrPerechi + 1];
            Random r = new Random();
            for (i = 0; i <= nrPerechi; ++i)
                perechi[i] = 0;
            foreach (PictureBox p in groupBox1.Controls)
            {
                do
                {
                    tag = 1 + r.Next(nrPerechi);
                } while (perechi[tag] == 2);
                perechi[tag]++;
                p.Tag = tag;
            }
        }

        PictureBox pictureBoxAux = null;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if ((sender as PictureBox) == pictureBoxAux)
                return;
            (sender as PictureBox).Load("Resurse\\Memory\\" + Convert.ToString((sender as PictureBox).Tag) + ".jpg");
            (sender as PictureBox).SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            if (pictureBoxAux == null)
                pictureBoxAux = sender as PictureBox;
            else
                if (pictureBoxAux.Tag.Equals((sender as PictureBox).Tag) == true)
            {
                pictureBoxAux.Enabled = false;
                (sender as PictureBox).Enabled = false;
                richTextBox1.LoadFile("Resurse\\Memory\\" + Convert.ToString((sender as PictureBox).Tag) + ".rtf");
                pictureBoxAux = null;
            }
            else
            {
                this.Refresh();
                Thread.Sleep(1000);
                (sender as PictureBox).Load("Resurse\\Memory\\0.jpg");
                pictureBoxAux.Load("Resurse\\Memory\\0.jpg");
                pictureBoxAux = null;
            }
        }
    }
}
