using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakipOto.DAL.DTO;
using StokTakipOto.DAL.DAO;
using StokTakipOto.DAL;

namespace StokTakipOto.BLL
{
    class MusteriBLL : IBLL<MusteriDetayDTO, MusteriDTO>
    {
        MusteriDAO dao = new MusteriDAO();
        public bool Delete(MusteriDetayDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int TableID, MusteriDetayDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(MusteriDetayDTO entity)
        {
            MUSTERI musteri = new MUSTERI();
            musteri.MusteriAd = entity.MusteriAd;
            musteri.isDeleted = false;
            return dao.Insert(musteri);
        }

        public MusteriDTO Select()
        {
            MusteriDTO dto = new MusteriDTO();
            dto.Musteriler = dao.Select();
            return dto;
        }

        public bool Update(MusteriDetayDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
