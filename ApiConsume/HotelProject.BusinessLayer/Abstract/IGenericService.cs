using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IGenericService<T>where T:class    //MANAGER TARAFINDA ÇAĞIRIRKEN HEM BUSİNESS`DE OLAN DATAACCESS`TEN AYIRABİLMEK ADINA BAŞINA T KOYDUK
    {
        void TInsert(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetByID(int id);
    }
}
