using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Biblo.DataLayer.Entities
{
    public class Book
    {
        [Key]
        public int id { get; set; }
        
        public String title { get; set; }

        public Author author { get; set; }

        [ForeignKey("authorId")]
        public int authorId { get; set; }

    }
}
