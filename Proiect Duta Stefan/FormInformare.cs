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
    public partial class FormInformare : Form
    {
        public FormInformare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAlbumFotoPagini f = new FormAlbumFotoPagini();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMozaic f = new FormMozaic();
            f.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Table_tennis");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://sfaturi.decathlon.ro/reguli-tenis-de-masa-detalii-tehnice-si-regulamentul-de-joc");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Resurse\\pingpong.ppsx");
        }
    }
}
