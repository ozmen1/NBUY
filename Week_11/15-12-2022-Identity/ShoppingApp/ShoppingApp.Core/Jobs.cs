using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Core
{
    public static class Jobs //static yaparak new yapılmasını engelledik
    {
        public static string InitUrl(string url)
        {
            #region Açıklamalar
            //Bu method kendisine gelen Url değişkeninin içindeki 
            //1. latin alfabesine cevrilirken problem çıkaran İ-i, ı-i gibi dönüştürmeleri yapacak (ç,ğ' gibi harflerde sorun yok onları tolower çevirebiliyor)
            //2. diğer türkçe karakterlerin yerine latin alfebesindeki karşılıklarını koyacak
            //3. boşluklar yerine - koyacak
            //4. nokta, slash gibi karakterleri kaldıracak
            #endregion

            #region SorunluKarakterler
            url = url.Replace("I", "i");
            url = url.Replace("İ", "i");
            url = url.Replace("ı", "i");
            #endregion

            #region KucukHarfeCevirme
            url = url.ToLower();
            #endregion

            #region TurkceKarakterlerDonusturme
            url = url.Replace("ö", "o");
            url = url.Replace("ü", "u");
            url = url.Replace("ş", "s");
            url = url.Replace("ç", "c");
            url = url.Replace("ğ", "g");
            #endregion

            #region BosluklarTireyeCevirme
            url = url.Replace(" ", "-");
            #endregion

            #region SorunluKarakterlerKaldiriliyor
            url = url.Replace(".", "");
            url = url.Replace("/", "");
            url = url.Replace("\"", "");
            url = url.Replace("'", "");
            url = url.Replace("(", "");
            url = url.Replace(")", "");
            url = url.Replace("[", "");
            url = url.Replace("]", "");
            url = url.Replace("{", "");
            url = url.Replace("}", "");
            #endregion



            return url;
        }
        public static string UploadImage(IFormFile image)
        {
            var extension = Path.GetExtension(image.FileName);
            var randomName = $"{Guid.NewGuid()}{extension}"; //rastgele değer üretmek için
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", randomName); //nereye ve nasıl yüklenecek
            //http://localhost:5001/wwwroot/images/3r34343w.png
            using(var stream = new FileStream(path, FileMode.Create))
            {
                image.CopyTo(stream);
            }
            return randomName;
        }
    }
}
