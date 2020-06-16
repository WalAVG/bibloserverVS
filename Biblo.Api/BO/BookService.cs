using AutoMapper.QueryableExtensions;
using Biblo.Api.Dto.Get;
using Biblo.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblo.Api.BO
{
    public class BookService
    {
        private readonly BibloDbContext _bibloDbContext;

        public BookService(BibloDbContext bibloDbContext)
        {
            _bibloDbContext = bibloDbContext;
        }
        public IQueryable<BookDTO> Get()
        {
            return _bibloDbContext.Books.ProjectTo<BookDTO>();
        }

    }
}
