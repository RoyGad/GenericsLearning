using System.Linq;
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

        public void PrintStudents(int count = 100)
        {
            var students = _studentRepository.List()
            .Take(count).ToArray();

            //sort
            //Array.Sort(students);

            Console.WriteLine("Students: ");

            for (int i = 0; i < students.Count(); i++)
            {
                Console.WriteLine(students[i]);
            }
        }
    }
}
