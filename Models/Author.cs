
using System;

namespace GenericsLearning.Models
{
    internal class Author: IComparable<Author>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Author(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }
        public override string ToString()
        {
            return ($"{FirstName} {LastName}");
        }

        public int CompareTo(Author? other)
        {
            if (other is null) return 1;
            return this.ToString().CompareTo(other.ToString());
        }
    }
}
