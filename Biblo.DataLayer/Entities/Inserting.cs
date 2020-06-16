using Biblo.DataLayer.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Biblo.DataLayer.Entities
{
    public class Inserting
    {
        [Key]
        public int id { get; set; }

        public String title { get; set; }

        [ForeignKey("userId")]
        public int userId { get; set; }

        public DateTime publishDate { get; set; }

        public String description { get; set; }

        public String genres { get; set; }

        public String genreSelected { get; set; }

        public String geolocation { get; set; }

        public int pictureId { get; set; }

       // public IEnumerable<CategoryTypes> categories { get; set; }

    }
}
