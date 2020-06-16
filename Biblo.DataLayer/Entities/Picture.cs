using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Biblo.DataLayer.Entities
{
    public class Picture
    {
        [Key]
        public int id { get; set; }

        public String url { get; set; }

    }
}
