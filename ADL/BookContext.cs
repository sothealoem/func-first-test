using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookPo.Models;

namespace BookPo.ADL
{
    public class BookContext:DbContext
    {
        //configuration connection string 
        public BookContext(DbContextOptions<BookContext> op):base(op)
        {

        }
        //setting db set properties
        public DbSet<Book> Books { get; set; }
    }
}
