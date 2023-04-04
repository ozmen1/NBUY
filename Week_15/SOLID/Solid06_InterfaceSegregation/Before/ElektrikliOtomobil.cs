using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid06_InterfaceSegregation.Before
{
    public class ElektrikliOtomobil : IOtomobil, IElektrikliOtomobil
    {
        public string BataryaTipi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string BataryaTipiniGetir()
        {
            throw new NotImplementedException();
        }

        public decimal VoltajDegeriniGetir()
        {
            throw new NotImplementedException();
        }
    }
}
