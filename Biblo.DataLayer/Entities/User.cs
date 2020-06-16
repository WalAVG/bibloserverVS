using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Biblo.DataLayer.Entities
{
    public class User
    {
        [Key]
        public int id { get; set; }

        public String username { get; set; }

        public String password { get; set; }

        public String email { get; set; }

        public String phoneNumber { get; set; }

        [ForeignKey("pictureId")]
        public int pictureId { get; set; }

        public String geolocation { get; set; }


    }
}
