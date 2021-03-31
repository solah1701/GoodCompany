using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodCompany.Services
{
    public interface IPersistence<T>
    {
        void Add(T item);
        void Save();
        List<T> Load();
    }
}
