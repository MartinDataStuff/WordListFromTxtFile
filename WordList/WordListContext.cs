using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WordList.Entities;

namespace WordList.Infrastructure
{
    public class WordListContext : DbContext
    {
        public WordListContext(DbContextOptions<WordListContext> options)
            : base(options)
        {
        }

        public DbSet<DTOFile> Booking { get; set; }

    }
}
