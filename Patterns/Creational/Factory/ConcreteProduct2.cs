namespace DesignPatterns_RefactoringGuru.Patterns.Creational.Factory
{
    /// <summary>
    /// Concrete Products provide various implementations of the Product interface.
    /// </summary>
    internal class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
