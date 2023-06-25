namespace DesignPatterns_RefactoringGuru.Patterns.Creational.Prototype
{
    internal class Client
    {
        public static void DisplayValues(Person p)
        {
            Console.WriteLine($"Name: {p.Name}, Age: {p.Age}, BirthDate: {p.BirthDate}");
            Console.WriteLine($"ID#: {p.IdInfo.IdNumber}");
        }

        public void Main()
        {
            Person p1 = new Person();
            p1.Age = 42;
            p1.BirthDate = Convert.ToDateTime("1997-01-01");
            p1.Name = "Jack Daniels";
            p1.IdInfo = new IdInfo(666);

            // Person a shallow copy of p1 and assing it to p2.
            Person p2 = p1.ShallowCopy();
            
            // Make a deep copy of p1 and assing it to p3.
            Person p3 = p2.DeepCopy();

            // Display values of p1, p2 and p3.
            Console.WriteLine("Original values of p1, p2 and p3:");
            
            Console.WriteLine("p1 instance values:");
            DisplayValues(p1);

            Console.WriteLine("p2 instance values:");
            DisplayValues(p2);

            Console.WriteLine("p3 instance values:");
            DisplayValues(p3);

            // Change the values of p1 properties and display the values of p1, p2 and p3.
            p1.Age = 32;
            p1.BirthDate = Convert.ToDateTime("1900-01-01");
            p1.Name = "Frank";
            p1.IdInfo.IdNumber = 7878;

            Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");

            Console.WriteLine("p1 instance values: ");
            DisplayValues(p1);

            Console.WriteLine("p2 instance values (reference values have changed):");
            DisplayValues(p2);

            Console.WriteLine("p3 instance values (everything was kept the same):");
            DisplayValues(p3);
        }
    }
}