namespace Project07_Constructor_Methods
{
    class Person
    {
        public Person() //Constructor methoddur ve tipi olmaz!
        {
            //her class'ın default olarak boş bir constructor methodu vardır ama implicittir, yani örtülü, gizlidir. Şu anda biz kendimiz bir constructor yazdık!
            //Constructor method ilkgili classtan new keywordü ile yeni bir nesne yaratıldığı esnada çalışacak kodları barındırır.
            //yani bu classtan bir nesne üretildiği anda buradaki kodlar çalışır.
            //her class'ın default boş bir constructor'u vardır ancak biz ayrıca bir constructor oluşturduysak o zaman kendi yazdığımız constructor geçerli.

            Console.WriteLine("Merhaba, ben Person, şu anda yaratıldım!");
        }
        public Person(string firstName, string lastName) //person methodu overload edildi.
        {
            this.FirstName = firstName; //this yazmak şart değil, değişken isimlendirme kurallarına uyulursa this yazmaya gerek kalmaz.
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Student: Person
    {
        public Student(string firstName, string lastName, int studentNumber): base(firstName, lastName) //base:miras alınan class. best practise'lere uygun kodlamak için base yapısını kullanmak gerek. miras alınan class'a yönlendirdi.
        {
            StudentNumber = studentNumber;
        }
        public int StudentNumber { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person();

            //Person person2 = new Person("Kerem", "Özmen"); //nesneyi oluştururken özelliklerini verdik. (constructor methodu kullanarak)

            //Console.WriteLine($"{person2.FirstName}, {person2.LastName}");

            Student student1 = new Student("Ahmet", "Can", 20); //constructor methodu ile birlikte student1 nesnesi oluşturuldu.

            Console.WriteLine($"{student1.FirstName}, {student1.LastName}, {student1.StudentNumber}");

            Console.ReadLine();
        }
    }
}