using GenericsLearning.Interfaces;
using GenericsLearning.Models;

namespace GenericsLearning.Services
{
    internal class AuthorPrinterService
    {
        private readonly IRepository<Author> _authorRepository;

        public AuthorPrinterService(IRepository<Author> authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public void PrintAuthors()
        {
            var authors = _authorRepository.List();

            //sort

            Array.Sort(authors);

            for (int i = 0; i < authors.Count(); i++)
            {
                Console.WriteLine(authors[i]);
            }
        }
    }
}
