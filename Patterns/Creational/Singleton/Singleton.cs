using DesignPatterns_RefactoringGuru.Patterns.Creational.Singleton.NonThreadSafe;
using DesignPatterns_RefactoringGuru.Patterns.Creational.Singleton.ThreadSafe;

namespace DesignPatterns_RefactoringGuru.Patterns.Creational.Singleton
{
    internal class Singleton
    {
        public static void TestSingleton(string value)
        {
            ThreadSafeSingleton singleton = ThreadSafeSingleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }

        public static void Main()
        {
            // Non Thread Safe
            // NonSafeSingleton s1 = NonSafeSingleton.GetInstance();
            // NonSafeSingleton s2 = NonSafeSingleton.GetInstance();

            // if (s1 == s2) Console.WriteLine("Singleton works, both variables contain the same instance.");

            // else Console.WriteLine("Singleton failed, variables contain different instances.");

            // Thread Safe
            Console.WriteLine("{0}\n{1}\n\n{2}\n",
            "If you see the same value, then singleton was reused (yay!)",
            "If you see different values, then 2 singletons were created (booo!!)",
            "RESULT:");

            Thread p1 = new Thread(() =>
            {
                TestSingleton("FOO");
            });

            Thread p2 = new Thread(() =>
            {
                TestSingleton("BAR");
            });

            p1.Start();
            p2.Start();

            p1.Join();
            p2.Join();
        }
    }
}
