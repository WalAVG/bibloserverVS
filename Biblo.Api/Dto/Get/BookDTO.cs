using Biblo.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblo.Api.Dto.Get
{
    public class BookDTO
    {
        public int id { get; set; }

        public String title { get; set; }

        public Author author { get; set; }

        public int authorId { get; set; }

    }
}
