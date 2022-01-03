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

            var startingOnEquinox = Seasons.Spring | Seasons.Autumn | Seasons.Summer;

            Console.WriteLine("________________________________________________");

            Console.WriteLine(startingOnEquinox);

            Console.WriteLine("________________________________________________");

            int i = 15;
            int j = 20;

            Swap(ref i, ref j);

            Console.WriteLine($"i is {i} and j is {j}");

            Console.WriteLine("________________________________________________");

            var authorService = new AuthorPrinterService(new AuthorRespository());
            authorService.PrintAuthors();

        }
        //testing commit
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

    }
}

