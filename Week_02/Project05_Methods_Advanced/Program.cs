namespace Project05_Methods_Advanced
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Year { get; set; }

            public string Intro()
            {
                return $"Ad: {this.Name}, Yaş: {this.CalculateAge()}";  //this: nesnedeki Name'i alır
            }

            private int CalculateAge()
            {
                return DateTime.Now.Year - this.Year;
            }
        }
        
        static void Main(string[] args)
        {
            Person person1 = new Person() { Name = "Engin", Year = 1975 };
            Person person2 = new Person() { Name = "Umay", Year = 2007 };
            Person person3 = new Person() { Name = "Begüm", Year = 2000 };
            Person person4 = new Person() { Name = "Ayşen", Year = 1985 };
            Person person5 = new Person() { Name = "Ceyda", Year = 1990 };

            Console.WriteLine(person1.Intro());

            Console.ReadLine();
        }
    }
}