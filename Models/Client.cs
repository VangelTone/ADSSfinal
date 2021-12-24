using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final4659.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public int LibraryId { get; set; }

        public Client()
        {

        }
    }
}
