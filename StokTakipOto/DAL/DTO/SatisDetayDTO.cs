﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOto.DAL.DTO
{
    public  class SatisDetayDTO
    {
        public string  UrunAd { get; set; }
        public string MusteriAd { get; set; }

        public string KategoriAD { get; set; }
        public int Fiyat { get; set; }
        public DateTime SatisTarihi { get; set; }
        public int SatisMiktar { get; set; }
        public int StokMiktar { get; set; }
        public int SatisID { get; set; }
        public int UrunID { get; set; }
        public int MusteriID { get; set; }
        public int KategoriID { get; set; }
    }
}
