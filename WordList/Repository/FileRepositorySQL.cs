using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WordList.Entities;
using WordList.Interfaces;

namespace WordList.Infrastructure.Repository
{
    public class FileRepositorySQL : IRepository<DTOFile>
    {

        private readonly WordListContext db;
        public FileRepositorySQL(WordListContext context)
        {
            db = context;
        }
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
