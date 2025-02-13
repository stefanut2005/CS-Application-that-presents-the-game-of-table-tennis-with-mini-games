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
    public partial class FormNomenclator : Form
    {
        public FormNomenclator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ok = 1;
            foreach(Control x in this.Controls)
            {
                if (x is ComboBox)
                {
                    ComboBox c = (ComboBox)x;
                    if (!c.Text.Equals(c.Tag))
                    {
                        ok = 0;
                    }
                }
            }
            if (ok == 1)
                MessageBox.Show("Toate au fost rezolvate corect!");
            else
                MessageBox.Show("Incearca din nou!");
        }

        private void FormNomenclator_Load(object sender, EventArgs e)
        {

        }
    }
}
