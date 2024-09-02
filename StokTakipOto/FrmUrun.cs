﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StokTakipOto.DAL.DTO;
using StokTakipOto.BLL;

namespace StokTakipOto
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        private void txtKategoriAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUrunFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }
        public UrunDTO dto = new UrunDTO();
        private void FrmUrun_Load(object sender, EventArgs e)
        {
            cmbKategori.DataSource = dto.Kategoriler;
            cmbKategori.DisplayMember = "KategoriAd";
            cmbKategori.ValueMember = "ID";
            cmbKategori.SelectedIndex = -1;
        }
        UrunBLL bll = new UrunBLL();
        UrunDetayDTO detay = new UrunDetayDTO();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUrunAd.Text.Trim() == "")
                MessageBox.Show("Ürün Adı boş");
            else if (txtUrunFiyat.Text.Trim() == "")
                MessageBox.Show("Fiyat alanı boş");
            else if (cmbKategori.SelectedIndex == -1)
                MessageBox.Show("Kategori seçiniz");
            else
            {
                detay.UrunAd = txtUrunAd.Text;
                detay.Fiyat = Convert.ToInt32(txtUrunFiyat.Text);
                detay.KategoriID = Convert.ToInt32(cmbKategori.SelectedValue);
                if(bll.Insert(detay))
                {
                    MessageBox.Show("Ürün eklendi");
                    txtUrunAd.Clear();
                    txtUrunFiyat.Clear();
                    cmbKategori.SelectedIndex = -1;




                }



            }
        }
    }
}
