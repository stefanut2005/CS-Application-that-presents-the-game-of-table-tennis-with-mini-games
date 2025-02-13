﻿using System;
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
    public partial class FormRelaxare : Form
    {
        public FormRelaxare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMemory f = new FormMemory();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPuzzle f = new FormPuzzle();
            f.ShowDialog();
        }
    }
}
