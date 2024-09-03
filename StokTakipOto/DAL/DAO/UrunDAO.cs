﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using StokTakipOto.DAL.DTO;

namespace StokTakipOto.DAL.DAO
{
     class UrunDAO : StokContext, IDAO<URUN, UrunDetayDTO>
    {
        public bool Delete(URUN entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(URUN entity)
        {
            try
            {
                db.URUN.Add(entity);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<UrunDetayDTO> Select()
        {
            List<UrunDetayDTO> liste = new List<UrunDetayDTO>();
            var list = (from u in db.URUN
                        join
                        k in db.KATEGORI on u.KategoriID equals k.ID
                        select new
                        {
                            urunad = u.UrunAd,
                            stok = u.Stok,
                            fiyat = u.Fiyat,
                            urunID = u.ID,
                            kategoriad = k.KategoriAd,
                            kID = k.ID


                        }).OrderBy(x => x.urunad).ToList();

            foreach (var item in list)
            {
                UrunDetayDTO dto = new UrunDetayDTO();
                dto.Fiyat = item.fiyat;
                dto.ID = item.urunID;
                dto.KategoriAd = item.kategoriad;
                dto.KategoriID = item.kID;
                dto.StokMiktar = item.stok;
                dto.UrunAd = item.urunad;
                liste.Add(dto);


            }

            return liste;
        }

        public bool Update(URUN entity)
        {
            try
            {
                URUN urun = db.URUN.First(x => x.ID == entity.ID);
                if (entity.Fiyat == 0)
                {

                    urun.Stok = entity.Stok;
                }
                else
                {
                    urun.KategoriID = entity.KategoriID;
                    urun.UrunAd = entity.UrunAd;
                    urun.Fiyat = entity.Fiyat;

                }



                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
