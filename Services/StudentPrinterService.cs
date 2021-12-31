using GenericsLearning.Interfaces;
using GenericsLearning.Models;

namespace GenericsLearning.Services
{
    internal class StudentPrinterService
    {
        private readonly IRepository<Student> _studentRepository;

        public StudentPrinterService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void PrintStudents()
        {
            var students = _studentRepository.List();

            //sort
            Array.Sort(students);

            Console.WriteLine("Students: ");
            for (int i = 0; i < students.Count(); i++)
            {
                Console.WriteLine(students[i]);
            }
        }
    }
}
