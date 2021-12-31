using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLearning.Interfaces
{
    internal interface IRepository<T>
    {
        T[] List();
    }
}
