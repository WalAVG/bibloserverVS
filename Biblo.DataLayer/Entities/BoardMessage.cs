using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Biblo.DataLayer.Entities
{
    public class BoardMessage
    {
        [Key]
        public int id { get; set; }

        public String text { get; set; }

        public DateTime publishDate { get; set; }

        [ForeignKey("commentBoardId")]
        public int commentBoardId { get; set; }

        [ForeignKey("userId")]
        public int userId { get; set; }

    }
}
