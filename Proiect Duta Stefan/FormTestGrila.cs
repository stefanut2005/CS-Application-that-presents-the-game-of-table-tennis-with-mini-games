using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Duta_Stefan
{
    public partial class FormTestGrila : Form
    {
        public FormTestGrila()
        {
            InitializeComponent();
        }

        int nrIntrebari = 0, nrRaspunsuriCorecte = 0;
        StreamReader reader = new StreamReader("Resurse\\TestGrila\\intrebari.txt");
        private void CitesteIntrebare()
        {
            groupBox1.Text = reader.ReadLine();
            radioButton1.Text = reader.ReadLine();
            radioButton1.Tag = reader.ReadLine();
            radioButton2.Text = reader.ReadLine();
            radioButton2.Tag = reader.ReadLine();
            radioButton3.Text = reader.ReadLine();
            radioButton3.Tag = reader.ReadLine();

            radioButton1.Checked = true;
            radioButton2.Checked = true;
            radioButton3.Checked = true;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nrIntrebari == 1)
                button1.Text = "Verifica";

            if (VerificareIntrebare() == 1)
                nrRaspunsuriCorecte++;
            if (nrIntrebari > 0)
            {
                CitesteIntrebare();
                nrIntrebari--;
            }
            else
            {
                MessageBox.Show("Testul s-a incheiat! Ati raspuns la " + nrRaspunsuriCorecte + " intrebari corect!");
                this.Close();
            }
        }

        private void FormTestGrila_Load(object sender, EventArgs e)
        {
            nrIntrebari = Convert.ToInt32(reader.ReadLine());
            CitesteIntrebare();
            nrIntrebari--;
            nrRaspunsuriCorecte = 0;
        }

        private int VerificareIntrebare()
        {
            if (radioButton1.Checked == true && radioButton1.Tag.Equals("1"))
                return 1;
            if (radioButton2.Checked == true && radioButton2.Tag.Equals("1"))
                return 1;
            if (radioButton3.Checked == true && radioButton3.Tag.Equals("1"))
                return 1;
            return 0;
        }
    }
}
