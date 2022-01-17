namespace DesignPatterns_RefactoringGuru.Patterns.Creational.Builder
{
    /// <summary>
    /// The Builder interface specifies methods for creating the differents parts of the Product objects.
    /// </summary>
    internal interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
    }
}
