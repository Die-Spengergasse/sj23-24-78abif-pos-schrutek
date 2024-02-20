namespace Spg.Inheritance.Demo.Model
{
    public class Student : Person, IEquatable<Student>
    {
        public Student(string firstName, string lastName) 
            : base(firstName, lastName)
        { }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Student);
        }

        public bool Equals(Student? other)
        {
            return FirstName.Equals(other?.FirstName) && LastName.Equals(other?.LastName);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public new void IsLegalAge()
        {
            Console.WriteLine("Student.IsLegalAge()");
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public new void VirtualDemo()
        {
            Console.WriteLine("Student.VirtualDemo() (new)");
        }
    }
}
