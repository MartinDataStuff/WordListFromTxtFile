using System;
using System.Collections.Generic;

namespace WordList.Interfaces
{
    public interface IRepository<T>
    {
        void Create(T t);
        T Read(int id);
        void Update(T t);
        void Delete(int id);
        IEnumerable<T> Read();
    }
}
