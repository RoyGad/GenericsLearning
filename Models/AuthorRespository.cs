using System.Collections.Generic;
using GenericsLearning.Interfaces;

namespace GenericsLearning.Models
{
    internal class AuthorRespository : IRepository<Author>
    {
        public IEnumerable<Author> List()
        {
            var authors = new Author[5];
            authors[0] = new Author("Roy", "Gad");
            authors[1] = new Author("Sandy", "Baldwin");
            authors[2] = new Author("Evie", "Baldwin");
            authors[3] = new Author("Ally", "Walker");
            authors[4] = new Author("Lex", "Isaac");
            return authors;
        }
    }
}
