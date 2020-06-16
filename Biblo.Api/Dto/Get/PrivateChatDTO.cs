using Biblo.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblo.Api.Dto.Get
{
    public class PrivateChatDTO
    {
        public int id { get; set; }

        public int userId1 { get; set; }

        public int userId2 { get; set; }

        public ICollection<PrivateMessage> privateMessages { get; set; }

    }
}
