using System;
using System.Collections.Generic;
using TextfileWordList.BusinessLogic;
using Moq;
using WordList.Entities;
using WordList.Interfaces;
using Xunit;

namespace WordList.UnitTests
{
    public class FileManagerTests
    {
        private FileManager fileManager;

        private Mock<IRepository<DTOFile>> _fakeFileRepository;
        public FileManagerTests()
        {
            //mock repos
            _fakeFileRepository = new Mock<IRepository<DTOFile>>();


            //File Manager instance
            fileManager = new FileManager(_fakeFileRepository.Object);


            //Setup of Mock Files
            var files = new []
            {
                new DTOFile {Content = "A"},
                new DTOFile {Content = "B C"},
                new DTOFile {Content = "D E F"},
            };



            //Unit test setup for mock data, with getall rooms
            _fakeFileRepository.Setup(x => x.Read()).Returns(files);

            //Unit test setup for mock data, with specific room.
            _fakeFileRepository.Setup(y => y.Read(2)).Returns(files[1]);

            //Unit test setup for mock data with getall bookings
            _fakeFileRepository.Setup(x => x.Read()).Returns(files);

            //Unit test setup for mock data with specific booking
            _fakeFileRepository.Setup(y => y.Read(2)).Returns(files[1]);

        }
        [InlineData("", 0)]
        [InlineData("uqVev", 1)]
        [InlineData("uqVev slUlI HPIFu AgOfP AEqGy", 5)]
        [InlineData("uqVev slUlI HPIFu AgOfP AEqG yuqVev slUlI HPIFu AgOfP",9)]
        [InlineData("uqVev slUlI HPIFu AgOfP AEqGy uqVev slUlI HPIFu AgOfP AEqGy", 10)]
        [Theory]
        public void WordCount(string word, int expected)
        {

            Assert.Equal(expected, fileManager.WordCount(word));
        }
    }

}
