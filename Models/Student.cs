
using System;

namespace GenericsLearning.Models
{
    internal class Student : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public static int StudentCounter =0;


        public Student(string fName, string lName )
        {
            FirstName = fName ?? "First Name not provided";
            LastName = lName ?? "Last Name not provided";
            StudentCounter++;
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
