using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApi.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options) //dependency injection mantigi.
        {
            Database.EnsureCreated();
        }
        public DbSet<Book> Books { get; set; }
    }
}
