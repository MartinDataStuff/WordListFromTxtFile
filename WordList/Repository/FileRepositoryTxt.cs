using System;
using System.Collections.Generic;
using System.Text;
using WordList.Entities;
using WordList.Interfaces;

namespace WordList.Infrastructure.Repository
{
    public class FileRepositoryTxt : IRepository<DTOFile>
    {
        private readonly string _folderPath;
        public FileRepositoryTxt(string folderPath)
        {
            _folderPath = folderPath;
        }
        public void Create(DTOFile t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DTOFile Read(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DTOFile> Read()
        {
            throw new NotImplementedException();
        }

        public void Update(DTOFile t)
        {
            throw new NotImplementedException();
        }
    }
}
