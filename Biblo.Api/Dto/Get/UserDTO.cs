using Biblo.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblo.Api.Dto.Get
{
    public class UserDTO
    {
        public int id { get; set; }

        public String username { get; set; }

        public String password { get; set; }

        public String email { get; set; }

        public String phoneNumber { get; set; }

        public int pictureId { get; set; }

        public String geolocation { get; set; }
    }
}
