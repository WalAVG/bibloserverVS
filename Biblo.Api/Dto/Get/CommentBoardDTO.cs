using Biblo.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblo.Api.Dto.Get
{
    public class CommentBoardDTO
    {
        public int insertingId { get; set; }

        public ICollection<BoardMessage> messages { get; set; }
    }
}
