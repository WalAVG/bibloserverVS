using AutoMapper;
using AutoMapper.QueryableExtensions;
using Biblo.Api.Dto.Get;
using Biblo.DataLayer;
using Biblo.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblo.Api.BO
{
    public class PrivateMessageService
    {
        private readonly BibloDbContext _bibloDbContext;

        public PrivateMessageService(BibloDbContext bibloDbContext)
        {
            _bibloDbContext = bibloDbContext;
        }
        public IQueryable<PrivateMessageDTO> Get()
        {
            return _bibloDbContext.PrivateMessages.ProjectTo<PrivateMessageDTO>();
        }
        public int Post(PrivateMessageDTO privateMessageDTO)
        {
            PrivateMessage u = new PrivateMessage();
            Mapper.Map(privateMessageDTO, u);
            var result = _bibloDbContext.PrivateMessages.Add(u);
            _bibloDbContext.SaveChanges();
            return u.id;
        }

    }
}
