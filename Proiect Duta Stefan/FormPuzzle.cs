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
    public partial class FormPuzzle : Form
    {
        public FormPuzzle()
        {
            InitializeComponent();
        }

        Button[,] puzzleButton = new Button[3, 3];
        int[] numereOcupate = new int[10];

        private void FormPuzzle_Load(object sender, EventArgs e)
        {
            int laturaH, laturaW, numar;
            int i, j;

            laturaH = this.Height / 5;
            laturaW = this.Width / 5;

            for (i = 0; i < 10; ++i)
                numereOcupate[i] = 0;

            Random r = new Random();

            for (i = 0; i < 3; ++i)
            {
                for (j = 0; j < 3; ++j)
                {
                    puzzleButton[i, j] = new Button();
                    puzzleButton[i, j].Width = laturaW;
                    puzzleButton[i, j].Height = laturaH;
                    puzzleButton[i, j].Left = laturaW * (j + 1);
                    puzzleButton[i, j].Top = laturaH * (i + 1);
                    puzzleButton[i, j].BackColor = Color.Yellow;
                    puzzleButton[i, j].ForeColor = Color.White;
                    do
                    {
                        numar = r.Next(0, 9);
                    } while (numereOcupate[numar] != 0);
                    numereOcupate[numar] = 1;
                    puzzleButton[i, j].Text = Convert.ToString(numar);
                    puzzleButton[i, j].BackgroundImage = Image.FromFile("Resurse\\Puzzle\\" + numar.ToString() + ".jpg");

                    puzzleButton[i, j].Click += new EventHandler(puzzleButton_Click);

                    this.Controls.Add(puzzleButton[i, j]);
                }
            }

        }

        private void Vecin(int i, int j, out int iv, out int jv)
        {
            iv = i; jv = j;
            if (i > 0 && puzzleButton[i - 1, j].Text == "0")
                iv = i - 1;
            if (j > 0 && puzzleButton[i, j - 1].Text == "0")
                jv = j - 1;
            if (i < 2 && puzzleButton[i + 1, j].Text == "0")
                iv = i + 1;
            if (j < 2 && puzzleButton[i, j + 1].Text == "0")
                jv = j + 1;
        }

        private void Interschimba(int i1, int j1, int i2, int j2)
        {
            string aux;
            aux = puzzleButton[i1, j1].Text;
            puzzleButton[i1, j1].Text = puzzleButton[i2, j2].Text;
            puzzleButton[i1, j1].BackgroundImage = Image.FromFile("Resurse\\Puzzle\\" + puzzleButton[i1, j1].Text + ".jpg");
            puzzleButton[i2, j2].Text = aux;
            puzzleButton[i2, j2].BackgroundImage = Image.FromFile("Resurse\\Puzzle\\" + puzzleButton[i2, j2].Text + ".jpg");
        }

        private void puzzleButton_Click(object sender, EventArgs ev)
        {
            int iSender = 0, jSender = 0;
            int iVecinSender, jVecinSender;
            if ((sender as Button).Text == "0")
                MessageBox.Show("Nu se poate muta patratul gol!");
            else
            {
                for (int i = 0; i < 3; ++i)
                {
                    for (int j = 0; j < 3; ++j)
                    {
                        if ((sender as Button) == puzzleButton[i, j])
                        {
                            iSender = i;
                            jSender = j;
                        }
                    }
                }
                Vecin(iSender, jSender, out iVecinSender, out jVecinSender);
                Interschimba(iSender, jSender, iVecinSender, jVecinSender);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nr = 0;
            bool ok = true;
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    if (puzzleButton[i, j].Text != Convert.ToString(nr))
                        ok = false;
                    else
                        nr++;
                }
            }
            if (ok == true)
                MessageBox.Show("Bravo!");
            else
                MessageBox.Show("Nu e gata!");
        }
    }
}
