using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakipOto.DAL.DTO;
using StokTakipOto.DAL;
using StokTakipOto.DAL.DAO;
using System.Data.Entity.Core.Metadata.Edm;

namespace StokTakipOto.BLL
{
    internal class KategoriBLL : IBLL<KategoriDetayDTO, KategoriDTO>
    {
        KategoriDAO dao = new KategoriDAO();
        UrunDAO urundao = new UrunDAO();
        public bool Delete(KategoriDetayDTO entity)
        {
            KATEGORI kategori = new KATEGORI();
            kategori.ID = entity.ID;
            dao.Delete(kategori);
            URUN urun = new URUN();
            urun.KategoriID = entity.ID;
            urundao.Delete(urun);
            return true;



        }

        public bool GetBack(int TableID, KategoriDetayDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(KategoriDetayDTO entity)
        {
            KATEGORI kategori = new KATEGORI();
            kategori.KategoriAd = entity.KategoriAd;
            kategori.isDeleted = false;
            return dao.Insert(kategori);
        }

        public KategoriDTO Select()
        {
            KategoriDTO dto = new KategoriDTO();
            dto.Kategoriler = dao.Select();
            return dto;
        }

        public bool Update(KategoriDetayDTO entity)
        {
            KATEGORI kt = new KATEGORI();
            kt.ID = entity.ID;
            kt.KategoriAd = entity.KategoriAd;
            return dao.Update(kt);
        }
    }
}
