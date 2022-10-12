using System.Collections;

namespace Project10_Collections_ArrayList
{
    internal class Program
    {
        static void Yazdir(ArrayList arraylist)
        {
            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            //arraylistlerde length yerine count kullanıyoruz.
            ArrayList sayilar = new ArrayList() { 54, 12, 66, 34, 19 };
            Console.WriteLine("Default Sıra");
            Yazdir(sayilar);
            //for (int i = 0; i < sayilar.Count; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            Console.WriteLine("**********");
            Console.WriteLine("Küçükten büyüğe Sıra");
            sayilar.Sort(); //Küçükten büyüğe sırala
            Yazdir(sayilar);

            Console.WriteLine("**********");
            Console.WriteLine("Büyükten küçüğe Sıra");
            sayilar.Reverse();
            Yazdir(sayilar);







            //ArrayList myList = new ArrayList();

            //myList.Add(120);
            //myList.Add("120");
            ////myList.Add("Zeynep");
            //myList.Add(11.5);
            //myList.Add(DateTime.Now);
            //myList.Add(true);
            //myList.Insert(0, "Yeni eleman"); //0. indis yerine yazıldı. Geri kalan elemanları ittirdi. Insert araya girer.


            //ArrayList addedList = new ArrayList()
            //{
            //    "Ayşen Umay",
            //    "Fercan Sercan",
            //    "Kazım Kolkanat"
            //};
            //myList.InsertRange(4, addedList);
            //myList.AddRange(addedList); //listenin sonuna ekledi.

            ////myList.Remove("120");
            ////myList.RemoveAt(0); //0. sıradakini siliyor
            ////myList.RemoveRange(0, 5); //0. indisten itibaren 5 tanesini sildi.


            //foreach (var item in myList)
            //{
            //    Console.WriteLine(item);
            //}

            //if (myList.Contains("Zeynep") == true)
            //{
            //    Console.WriteLine("Evet, Zeynep listede mevcut!");
            //}
            //else
            //{
            //    Console.WriteLine("Acil, Zeynep'e haber ver! Listede yok!");
            //}

            //Console.WriteLine();
            ////Console.WriteLine(myList[3]);




            Console.ReadLine();
        }
    }
}