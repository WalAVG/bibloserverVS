using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Biblo.DataLayer.Entities
{
    public class PrivateChat
    {
        [Key]
        public int id { get; set; }

        public int userId1 { get; set; }

        public int userId2 { get; set; }

        public ICollection<PrivateMessage> privateMessages { get; set; }

    }
}
