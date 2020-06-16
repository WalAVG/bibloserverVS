using AutoMapper.QueryableExtensions;
using Biblo.Api.Dto.Get;
using Biblo.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblo.Api.BO
{
    public class CommentBoardService
    {
        private readonly BibloDbContext _bibloDbContext;

        public CommentBoardService(BibloDbContext bibloDbContext)
        {
            _bibloDbContext = bibloDbContext;
        }
        public IQueryable<CommentBoardDTO> Get()
        {
            return _bibloDbContext.CommentBoards.ProjectTo<CommentBoardDTO>();
        }

    }
}
