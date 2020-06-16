using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Biblo.DataLayer.Entities
{
    public class Address
    {
        public String nation { get; set; }

        public String region { get; set; }

        public String city { get; set; }

        [Key]
        public int id { get; set; }
    }
}
