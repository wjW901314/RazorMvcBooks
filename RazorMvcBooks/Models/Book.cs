using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorMvcBooks.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
    }
}
