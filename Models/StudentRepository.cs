using GenericsLearning.Interfaces;

public record Name (string fName, string lName);

namespace GenericsLearning.Models
{
    internal class StudentRepository : IRepository<Student>
    {
        public Name[] _names = new Name[10];
        public List<Student> students = new List<Student>();

        public StudentRepository()
        {
            _names[0] = new Name("Roy", "Gad");
            _names[2] = new("Evie", "Baldwin");
            _names[3] = new("Ally", "Martin");
            _names[1] = new("Sandy", "Baldwin");
            _names[4] = new("Lex", "Isaac");
        }
        public IEnumerable<Student> List()
        {
            Console.WriteLine(students.Count());
            var counter = _names.Count();
        
            for (int i = 0; i < 4; i++)
            {
                students.Add(new Student(_names[i].fName, _names[i].lName));
            }
            return students;
        }
    }
}
