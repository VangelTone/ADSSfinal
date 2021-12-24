using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final4659.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Author { get; set; }

        public int Year { get; set; }

        public Client Client { get; set; }

        public Book()
        {

        }
    }
}
