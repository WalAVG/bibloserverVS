using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Biblo.DataLayer.Entities
{
    public class CommentBoard
    {
        [Key]
        public int insertingId { get; set; }

        public ICollection<BoardMessage> messages { get; set; }

    }
}
