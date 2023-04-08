using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{                                                           //ABSTRACT KLASÖRÜNÜN IMPLEMENT EDİLDİĞİ KLASÖR CONCRETE. BURADA IMPLEMENTE İŞLEMLERİ YAPIYORUZ.
                                                            //MANAGER GENERIC BİR YAPIDA OLABİLİR. ŞUAN BEN GENERIC KULLANMAYACAĞIM.
    public class RoomManager : IRoomService               //MİRAS ALDIK
    {
        private readonly IRoomDal _roomDal;     //DEPENDS INJECTION UYGULADIK. BİR FİELD OLUŞTURDUK

        public RoomManager(IRoomDal roomDal)      //GENERATE CONSTRUCTOR YAPTIK
        {
            _roomDal = roomDal;
        }

        public void TDelete(Room t)
        {
            _roomDal.Delete(t);
        }

        public Room TGetByID(int id)
        {
            return _roomDal.GetByID(id);
        }

        public List<Room> TGetList()
        {
            return _roomDal.GetList();
        }

        public void TInsert(Room t)
        {
            _roomDal.Insert(t);

        }

        public void TUpdate(Room t)
        {
            _roomDal.Update(t);
        }
    }
}
