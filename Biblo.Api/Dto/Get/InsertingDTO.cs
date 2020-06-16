using Biblo.DataLayer.Entities;
using Biblo.DataLayer.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblo.Api.Dto.Get
{
    public class InsertingDTO
    {

        public int id { get; set; }

        public String title { get; set; }

        public int userId { get; set; }

        public DateTime publishDate { get; set; }

        public String description { get; set; }

        public String genres { get; set; }

        public String geolocation { get; set; }

        public String genreSelected { get; set; }

        public int pictureId { get; set; }

     //   public IEnumerable<CategoryTypes> categories { get; set; }
    }
}
