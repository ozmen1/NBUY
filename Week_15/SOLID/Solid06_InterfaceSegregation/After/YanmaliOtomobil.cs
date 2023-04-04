using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid06_InterfaceSegregation.After
{
    public class YanmaliOtomobil : IOtomobilOrtak, IYanmaliMotor
    {
        public int KapiSayisi()
        {
            throw new NotImplementedException();
        }

        public double MotorGucunuGetir()
        {
            throw new NotImplementedException();
        }

        public int UretimYili()
        {
            throw new NotImplementedException();
        }

        public string YakitTipiniGetir()
        {
            throw new NotImplementedException();
        }
    }
}
