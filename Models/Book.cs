using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Book
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public int PageCount { get; set; }

        public DateTime PublishDate { get; set; }

        public DateTime DateCreated { get; set; }

        public decimal Price { get; set; }


    }
}
