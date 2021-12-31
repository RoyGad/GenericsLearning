using GenericsLearning.Models;

namespace GenericsLearning.Interfaces
{
    internal interface IAuthorRepository
    {
        Author[] List();
    }
}