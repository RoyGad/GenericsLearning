
namespace GenericsLearning.Models
{
    internal class Student : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        public override string ToString()
        {
            return ($"{FirstName} {LastName}");
        }

        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;
            if (obj is Student otherStudent)
            {
                if (this.LastName == otherStudent.LastName) return this.FirstName.CompareTo(otherStudent.FirstName);
                return this.LastName.CompareTo(otherStudent.LastName);
            }
            throw new ArgumentException("Object is not a Student", nameof(obj));
        }
    }
}
