﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectModels.Models;

namespace ProjectModels
{
    public class Author
    {
        [Key]
        public int Author_Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        public int LastName { get; set; }

        public string BirthDate { get; set; }

        public string Location { get; set; }

        public List <Book> Books { get; set; }

        

        [NotMapped]
        public string FullName { 
            get
            {
                return $"{FirstName}{LastName}";
            }
                }
    }

}