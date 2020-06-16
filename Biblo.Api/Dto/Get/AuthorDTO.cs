using Biblo.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblo.Api.Dto.Get
{
    public class AuthorDTO
    {
        public String name { get; set; }
        
        public int id { get; set; }

        public int pictureId { get; set; }

    }
}
