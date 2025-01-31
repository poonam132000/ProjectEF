using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModels.Models
{
    public class Book

    {
        public int BookId { get; set; }
        public string Title { get; set; }

        [ForeignKey("Author")]
        public int Author_Id { get; set; }
        public double price { get; set; }
        public List<Author> Authors { get; set; }

    }
}
