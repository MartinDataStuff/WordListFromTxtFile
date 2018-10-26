using System.Linq;
using System.Text.RegularExpressions;
using WordList.Entities;
using WordList.Interfaces;

namespace TextfileWordList.BusinessLogic
{
    public class FileManager
    {
        private IRepository<DTOFile> _repository;
        public FileManager(IRepository<DTOFile> repository)
        {
            _repository = repository;
        }
        public int WordCount(string input)
        {
            var matches = Regex.Matches(input, @"\b[\w']*\b");

            var words = from m in matches
                where !string.IsNullOrEmpty(m.Value)
                select TrimSuffix(m.Value);
            

            return words.Count();
        }

        static string TrimSuffix(string word)
        {
            int apostropheLocation = word.IndexOf('\'');
            if (apostropheLocation != -1)
            {
                word = word.Substring(0, apostropheLocation);
            }

            return word;
        }
    }
}
