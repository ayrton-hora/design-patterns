namespace DesignPatterns_RefactoringGuru.Patterns.Creational.AbstractFactory
{
    /// <summary>
    /// Concrete Products are created by corresponding Concrete Factories.
    /// </summary>
    internal class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A2.";
        }
    }
}
