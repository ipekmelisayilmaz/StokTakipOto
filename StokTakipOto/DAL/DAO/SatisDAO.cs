using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakipOto.DAL.DTO;

namespace StokTakipOto.DAL.DAO
{
   class SatisDAO : StokContext, IDAO<SATIM, SatisDetayDTO>
    {
        public bool Delete(SATIM entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(SATIM entity)
        {
            try
            {
                db.SATIM.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception )
            {

                throw ;
            }
        }

        public List<SatisDetayDTO> Select()
        {
            try
            {
                List<SatisDetayDTO> liste = new List<SatisDetayDTO>();
                var list = (from s in db.SATIM
                            join u in db.URUN on s.UrunID equals u.ID
                             join k in db.KATEGORI on s.KategoriID equals k.ID
                            join m in db.MUSTERI on s.MusteriID equals m.ID
                            select new
                            {
                                musteriad = m.MusteriAd,
                                urunad = u.UrunAd,
                                kategoriad = k.KategoriAd,
                                fiyat = s.SatisFiyat,
                                satistarihi = s.SatisTarihi,
                                satismiktar = s.SatisMiktar,
                                stok = u.Stok,
                                satisID = s.ID,
                                urunID = s.UrunID,
                                musteriID = s.MusteriID,
                                kategoriID = s.KategoriID
                            }).OrderBy(x => x.satistarihi).ToList();

                foreach (var item in list)
                {
                    SatisDetayDTO dto = new SatisDetayDTO();
                    dto.MusteriAd = item.musteriad;
                    dto.UrunAd = item.urunad;
                    dto.KategoriAD = item.kategoriad;
                    dto.Fiyat = item.fiyat;
                    dto.SatisTarihi = item.satistarihi;
                    dto.SatisMiktar = item.satismiktar;
                    dto.StokMiktar = item.stok;
                    dto.SatisID = item.satisID;
                    dto.UrunID = item.urunID;
                    dto.MusteriID = item.musteriID;
                    dto.KategoriID = item.kategoriID;
                    liste.Add(dto);
                }



                return liste;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(SATIM entity)
        {
            throw new NotImplementedException();
        }
    }
}
