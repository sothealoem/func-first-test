using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookPo.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int Page { get; set; }
        public int Price { get; set; }
    }
}
