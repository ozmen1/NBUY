using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid01_SingleResponsibility.Before
{
    public class Customer
    {
        void Login(string username, string password)
        {
            //Login işlemeri ile ilgilşiş kodlar
        }

        void Register(string username, string password, string email)
        {
            //Register işlemleri
            SendMail("Kaydınız başarıyla gerçekleşmiştir.");
        }

        void SendMail(string text) 
        {
            //Mail gönderme işlemleri ile ilgili kodlar
        }


    }
}
