﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOto
{
    public partial class FrmSilinenler : Form
    {
        public FrmSilinenler()
        {
            InitializeComponent();
        }

        private void FrmSilinenler_Load(object sender, EventArgs e)
        {
            cmbTablolar.Items.Add("Kategoriler");
            cmbTablolar.Items.Add("Ürünler");
            cmbTablolar.Items.Add("Müşteriler");
            cmbTablolar.Items.Add("Satışlar");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
