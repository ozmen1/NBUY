using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02_Methods
{
    public class MethodOverload
    {
        public void DenemeMetodu()
        {
            Console.WriteLine("Mesaj! Method Overload");
        }

        public int Topla(int s1, int s2, int s3=0) //2 parametreli de, 3 parametreli de kullanmak için. (((default value atama)))
        {
            return s1 + s2 + s3;
        }

        //opsiyonel parametre argümanların sonunda olur.

        public int Islem(bool islemTuru, int s1, int s2, int s3 = 0) //gönderilen 3 sayı arasında istersem toplama, istersem çarpma yapsın.
        {
            if (islemTuru == true)
            {
                return s1 + s2 + s3;

            }
            else
            {
                if (s3 == 0) s3 = 1;
                return s1 * s2 * s3;
            }

        }
        //bir methodun farklı kullanım şekillerini oluşturma şekli=overload. parametre içeriği değiştirerek. (imzadaki parametre listesini kullanıyoruz)
        public int Topla(int[] sayilar)
        {
            int sonuc = sayilar.Sum();
            return sonuc;
        }
    }
}
