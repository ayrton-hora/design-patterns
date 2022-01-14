namespace DesignPatterns_RefactoringGuru.Patterns.Creational.AbstractFactory
{
    /// <summary>
    /// Each Concrete Factory has a corresponding product variant.
    /// </summary>
    internal class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
