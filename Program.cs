using GenericsLearning.Services;
using GenericsLearning.Models;

namespace GenericsLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Current time is: " + DateTime.Now);

            var studentService = new StudentPrinterService(new StudentRepository());
            studentService.PrintStudents();

            Console.WriteLine("________________________________________________");

            var authorService = new AuthorPrinterService(new AuthorRespository());
            authorService.PrintAuthors();
        
        }
    }
}

