using System;
using System.Linq;
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

        public void PrintAuthors(int count)
        {
            var authors = _authorRepository.List().ToArray();

            //sort
            //Array.Sort(authors);
            var displayNum = (count<= authors.Count()-1)? count: authors.Count();
            for (int i = 0; i < displayNum; i++)
            {
                Console.WriteLine(authors[i]);
            }

        }
    }
}
