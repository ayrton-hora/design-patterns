namespace DesignPatterns_RefactoringGuru.Patterns.Creational.Prototype
{
    internal class Person
    {
        public int Age;

        public DateTime BirthDate;

        public string Name;

        public IdInfo IdInfo;

        public Person ShallowCopy() => (Person) MemberwiseClone();

        public Person DeepCopy()
        {
            Person clone = (Person) MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = Name;
            return clone;
        }
    }
}