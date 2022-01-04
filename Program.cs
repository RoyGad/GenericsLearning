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
            studentService.PrintStudents(3);

            Console.WriteLine($"Number of students created: {Student.StudentCounter}");

            Console.WriteLine("________________________________________________");
            
            var startingOnEquinox = Seasons.Spring | Seasons.Autumn | Seasons.Summer;

            Console.WriteLine(startingOnEquinox);

            Console.WriteLine("________________________________________________");

            int i = 15;
            int j = 20;

            Swap(ref i, ref j);

            Console.WriteLine($"i is {i} and j is {j}");

            Console.WriteLine("________________________________________________");
            Entity.SetNextSerialNo(1000);
            Entity e1 = new();
            Entity e2 = new();
            var e3 = new Entity();
            Console.WriteLine(e1.GetSerialNo());         
            Console.WriteLine(e2.GetSerialNo());         
            Console.WriteLine(e3.GetSerialNo()); 
            Console.WriteLine(Entity.GetNextSerialNo()); 

             Console.WriteLine("________________________________________________");

            var authorService = new AuthorPrinterService(new AuthorRespository());
            authorService.PrintAuthors(5);

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

