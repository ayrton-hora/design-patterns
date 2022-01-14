namespace DesignPatterns_RefactoringGuru.Patterns.Creational.Factory
{
    /// <summary>
    /// Concrete Creators override the factory method in order to change the resulting product's type.
    /// </summary>
    internal class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
