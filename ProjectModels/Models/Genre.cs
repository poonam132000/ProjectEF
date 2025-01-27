﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModels.Models
{
    [Table("GenreTable")]
    public class Genre
    {
        
        public int GenreId { get; set; }

        public string GenreName { get; set; }

        public int Display { get; set; }
    }
}
