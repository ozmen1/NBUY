namespace Project06_Inheritance_Kalitim_Miras
{
    class Person //bir class, istenildiği kadar başka classa miras verebilir.
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public virtual void Intro() //virtual keywordü, bu metodun miras alınan classlarda override edilmesine izin verir!
        {
            Console.WriteLine($"First Name: {this.FirstName}, Last Name: {this.LastName}");
        }
    }
    class Writer: Person
    {
        public string BookName { get; set; }
    }
    class Teacher: Person
    {
        public string Branch { get; set; }
    }
    class Student: Person  //bir class sadece tek bir classtan miras alabilir. (aksi durumda interface devreye girer)
    {
        public int StudentNumber { get; set; }
        public override void Intro() //bu metodun miras alınan sınıftaki versiyonunu ezip, yok sayıp yerine bu metodu kabul eder.
        {
            Console.WriteLine($"First Name: {this.FirstName}, Last Name: {this.LastName}, Student Number: {this.StudentNumber}");
        }
    }
    class a
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
    }
    class b: a
    {
        public int MyProperty3 { get; set; }
        public int MyProperty4 { get; set; }
    }
    class c: b //c hem a hem b'den miras alıyor. ancak b a'dan miras almasaydı bu durum gerçekleşmezdi.
    {
        public int MyProperty5 { get; set; }
        public int MyProperty6 { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Student student = new Student();

            student.FirstName = "Kemal";
            student.LastName = "Kapucu";
            student.StudentNumber = 125;
            student.Intro();

            //Bir teacher tanımlayın, içini doldurun, ekrana yazdırın.

            Teacher teacher = new Teacher();
            teacher.FirstName = "Kerem";
            teacher.LastName = "Özmen";
            teacher.Branch = "Bilgisayar";
            teacher.Intro();

            Person person1 = new Student();
            // Student student1 = new Person(); //BU hatalı bir yaklaşımdır. Yoldan geçen her kişiye öğrencidir demektir.

            Console.ReadLine();
        }
    }
}