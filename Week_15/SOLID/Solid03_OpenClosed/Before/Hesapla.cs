﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid03_OpenClosed.Before
{
    public class Hesapla
    {
        //Bu metot kendisine gelen şekillerin alanlarının toplamını bulacak.

        public double AlanlariTopla(object[] sekiller) //buraya eşkenar için düzenleme yapmak gerekecek...bütün kodun değişmesi lazım.
        {
            double alanToplami = 0;
            foreach (var sekil in sekiller)
            {
                if (sekil is Kare)
                {
                    alanToplami += Math.Pow(((Kare)sekil).Kenar, 2);  //unboxing yaptık
                }
                else
                {
                    alanToplami += Math.PI * Math.Pow(((Daire)sekil).Yaricap, 2);
                }
            }
            return alanToplami;
        }
    }
}
