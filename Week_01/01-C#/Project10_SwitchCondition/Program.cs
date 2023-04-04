namespace Project10_SwitchCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Klavyeden girilen sayının 5 olması halinde 2 katını, 10 olması halinde 3 katını, 15 olması halinde 4 katını ekrana yazdıran. 
            ////Eğer üçü de değilse tanınmayan değer yaz.
            //int input = Convert.ToInt32(Console.ReadLine());
            //int sonuc = 0;
            //if (input == 5)
            //{
            //    sonuc = input * 2;
            //}
            //else if(input == 10)
            //{
            //    sonuc = input * 3;
            //}
            //else if(input == 15)
            //{
            //    sonuc = input * 4;
            //}
            //if (sonuc == 0)
            //{
            //    Console.WriteLine("Tanımlanmamış değer!");
            //}
            //else
            //{
            //    Console.WriteLine(sonuc);
            //}






            ////if kullanmadan
            //int input = Convert.ToInt32(Console.ReadLine());
            //int sonuc = 0;
            //switch (input)
            //{
            //    case 5:
            //        sonuc = input * 2;
            //        break;
            //    case 10:
            //        sonuc = input * 3;
            //        break;
            //    case 15:
            //        sonuc = input * 4;
            //        break;
            //    default:
            //        sonuc = 0;
            //        break;
            //}
            //if (sonuc == 0)
            //{
            //    Console.WriteLine("Tanımlanmamış değer.");
            //}
            //else
            //{
            //    Console.WriteLine(sonuc);
            //}





            //// x -> 10dan küçükse 2 ile çarp, 11 ile 20 arasındaysa 3 ile çarp, 21 ile 50 arasında 4 ile çarp, 51-100 *5, 100+++ *10
            //// İf ile çözüm 
            //// else kullandığımız için and yapısını kullanmaya gerek kalmadı
            //int x = 200;
            //int sonuc = 0;

            //if (x <= 10)
            //{
            //    sonuc = x * 2;
            //}
            //else if (x <= 20)
            //{
            //    sonuc = x * 3;
            //}
            //else if (x <= 50)
            //{
            //    sonuc = x * 4;
            //}
            //else if (x <= 100)
            //{
            //    sonuc = x * 5;
            //}
            //else
            //{
            //    sonuc = x * 10;
            //}
            //Console.WriteLine($"X: {x}, Sonuç: {x} * {sonuc/x} = {sonuc}");








            //// x -> 10dan küçükse 2 ile çarp, 11 ile 20 arasındaysa 3 ile çarp, 21 ile 50 arasında 4 ile çarp, 51-100 *5, 100+++ *10
            //// İf ile çözüm 
            //// else kullandığımız için and yapısını kullanmaya gerek kalmadı
            //int x = 200;
            //int katsayi = 0;

            //if (x <= 10)
            //{
            //    katsayi = 2;
            //}
            //else if (x <= 20)
            //{
            //    katsayi = 3;
            //}
            //else if (x <= 50)
            //{
            //    katsayi = 4;
            //}
            //else if (x <= 100)
            //{
            //    katsayi = 5;
            //}
            //else
            //{
            //    katsayi = 10;
            //}
            //int sonuc = x * katsayi;
            //Console.WriteLine($"X: {x}, Sonuç: {x} * {katsayi} = {sonuc}");







            ////switch case yapısıyla çözmek. and operatörü farklı şekilde kullandık.
            //int x = 200;
            //int katsayi = 0;
            //switch (x)
            //{
            //    case (>= 0 and <= 10):
            //        katsayi = 2;
            //        break;
            //    case (>= 11 and <= 20):
            //        katsayi = 3;
            //        break;
            //    case (>= 21 and <= 50):
            //        katsayi = 4;
            //        break;
            //    case (>= 51 and <= 100):
            //        katsayi = 5;
            //        break;
            //    default:
            //        katsayi = 6;
            //        break;
            //}
            //int sonuc = x * katsayi;
            //Console.WriteLine($"X: {x}, Sonuç: {x} * {katsayi} = {sonuc}");








            ////İçinde bulunduğumuz gün haftaiçi mi haftasonu mu bulalım
            //Console.WriteLine(DateTime.Now.DayOfWeek.ToString());    //dayofweek tipinden string tipine çevirdik.





            ////İçinde bulunduğumuz gün haftaiçi mi haftasonu mu bulalım
            //DateTime tarih = new DateTime(2022, 10, 5);
            //DayOfWeek gun = tarih.DayOfWeek;
            //if (gun == DayOfWeek.Sunday || gun == DayOfWeek.Saturday) 
            //{
            //    Console.WriteLine("Hafta sonu");
            //}
            //else
            //{
            //    Console.WriteLine("Hafta içindesin çalış çalış çalış");
            //}








            //DateTime tarih = new DateTime(2022, 10, 5);
            //DayOfWeek gun = tarih.DayOfWeek;
            //switch (gun)
            //{
            //    case DayOfWeek.Monday:
            //    case DayOfWeek.Tuesday:
            //    case DayOfWeek.Wednesday:
            //    case DayOfWeek.Thursday:
            //    case DayOfWeek.Friday:
            //        Console.WriteLine("Haftaiçi");
            //        break;
            //    case DayOfWeek.Saturday:
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("Haftasonu");
            //        break;
            //    default:
            //        break;






            DateTime tarih = new DateTime(2022, 10, 5);
            DayOfWeek gun = tarih.DayOfWeek;
            switch (gun)
            {
                case DayOfWeek.Monday or 
                    DayOfWeek.Tuesday or 
                    DayOfWeek.Wednesday or 
                    DayOfWeek.Thursday or 
                    DayOfWeek.Friday:
                    Console.WriteLine("Haftaiçi");
                    break;
                case DayOfWeek.Saturday or DayOfWeek.Sunday:
                    Console.WriteLine("Haftasonu");
                    break;
                default:
                    break;
            }
        }
    }
}