using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblo.Api.Dto.Get
{
    public class BoardMesssageDTO
    {
        public int id { get; set; }

        public String text { get; set; }

        public DateTime publishDate { get; set; }

        public int commentBoardId { get; set; }

        public int userId { get; set; }

    }
}
