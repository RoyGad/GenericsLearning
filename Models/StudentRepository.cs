using GenericsLearning.Interfaces;

namespace GenericsLearning.Models
{
    internal class StudentRepository : IRepository<Student>
    {
        public Student[] List()
        {
            var students = new Student[5];
            students[0] = new Student("Roy", "Gad");
            students[1] = new Student("Sandy", "Baldwin");
            students[2] = new Student("Evie", "Baldwin");
            students[3] = new Student("Ally", "Martin");
            students[4] = new Student("Lex", "Isaac");
            return students;
        }
    }
}
