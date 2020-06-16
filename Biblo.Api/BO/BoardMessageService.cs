using AutoMapper.QueryableExtensions;
using Biblo.Api.Dto.Get;
using Biblo.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblo.Api.BO
{
    public class BoardMessageService
    {
        private readonly BibloDbContext _bibloDbContext;

        public BoardMessageService(BibloDbContext bibloDbContext)
        {
            _bibloDbContext = bibloDbContext;
        }
        public IQueryable<BoardMesssageDTO> Get()
        {
            return _bibloDbContext.BoardMessages.ProjectTo<BoardMesssageDTO>();
        }

    }
}
