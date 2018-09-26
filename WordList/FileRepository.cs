using System.Collections.Generic;
using WordList.Entities;
using WordList.Interfaces;

namespace WordList.Infrastructure
{
    public class FileRepository : IRepository<DTOFile>
    {
        public void Create(DTOFile t)
        {
            throw new System.NotImplementedException();
        }

        public DTOFile Read(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(DTOFile t)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<DTOFile> Read()
        {
            throw new System.NotImplementedException();
        }
    }
}
