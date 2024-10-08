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
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }
        public MusteriDetayDTO detaydto = new MusteriDetayDTO();
        public bool isUpdate = false;
        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            if (isUpdate)
                txtMusteriAd.Text = detaydto.MusteriAd;

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        MusteriDetayDTO detay = new MusteriDetayDTO();
        MusteriBLL bll = new MusteriBLL();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtMusteriAd.Text.Trim() == "")
                MessageBox.Show("Müşteri Adı boş ");

            else
            {
                if(isUpdate)
                {
                    if (detaydto.MusteriAd == txtMusteriAd.Text)
                        MessageBox.Show("Değişiklik yok");
                    else
                    {
                        detaydto.MusteriAd = txtMusteriAd.Text;
                        if(bll.Update(detaydto))
                        {
                            MessageBox.Show("Güncellendi");
                            this.Close();


                        }


                    }


                }

                else
                {
                    detay.MusteriAd = txtMusteriAd.Text;
                    if (bll.Insert(detay))
                    {
                        MessageBox.Show("Müşteri eklendi");
                        txtMusteriAd.Clear();



                    }


                }




            }

        }
    }
}
