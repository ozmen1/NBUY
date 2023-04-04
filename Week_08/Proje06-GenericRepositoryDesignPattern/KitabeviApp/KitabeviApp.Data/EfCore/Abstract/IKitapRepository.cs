using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Abstract
{
    public interface IKitapRepository : IGenericRepository<Kitap>
    {
        //Þuan burada IGenericRepository'den gelen Kitap için hazýrlanmýþ CRUD metotlarý var.
        //Eðer bir class IKitapRep.den miras alýrsa, tüm bu CRUD metotlarý da oraya implemente edilir.
        //Buraya ayrýca yazýlacak metotlar(aþaðýdaki gibi) sadece kitap entity'sine özgü metotlardýr.
        List<Kitap> KategoriyeGoreKitapListesi(int id);
    }
}