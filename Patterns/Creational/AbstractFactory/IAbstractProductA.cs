namespace DesignPatterns_RefactoringGuru.Patterns.Creational.AbstractFactory
{
    /// <summary>
    /// Each distinct product of a product family should have a base interface.
    /// All variants of the product must implement this interface.
    /// </summary>
    internal interface IAbstractProductA
    {
        string UsefulFunctionA();
    }
}