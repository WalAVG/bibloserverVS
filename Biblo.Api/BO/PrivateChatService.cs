using AutoMapper;
using AutoMapper.QueryableExtensions;
using Biblo.Api.Dto.Get;
using Biblo.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblo.Api.BO
{
    public class PrivateChatService
    {
        private readonly BibloDbContext _bibloDbContext;

        public PrivateChatService(BibloDbContext bibloDbContext)
        {
            _bibloDbContext = bibloDbContext;
        }
        public IQueryable<PrivateChatDTO> Get()
        {
            return _bibloDbContext.PrivateChats.ProjectTo<PrivateChatDTO>();
        }
        public PrivateChatDTO Find(int id)
        {
            PrivateChatDTO result = new PrivateChatDTO();
            var chat = _bibloDbContext.PrivateChats.First(a => a.id == id);
            Mapper.Map(chat, result);
            return result;
        }

    }
}
