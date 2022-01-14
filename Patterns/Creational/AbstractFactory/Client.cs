namespace DesignPatterns_RefactoringGuru.Patterns.Creational.AbstractFactory
{
    /// <summary>
    /// The client code works with factories and products only through abstract
    /// types: AbstractFactory and AbstractProduct. This lets you pass any
    /// factory or product subclass to the client code without breaking it.
    /// </summary>
    internal class Client
    {
        public static void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }

        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ConcreteFactory1());
            
            Console.WriteLine("");

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new ConcreteFactory2());
        }
    }
}
