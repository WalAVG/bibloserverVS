using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Biblo.DataLayer.Entities
{
    public class Author
    {
        public String name { get; set; }
        [Key]
        public int id { get; set; }

        [ForeignKey("pictureId")]
        public int pictureId { get; set; }

    }
}
