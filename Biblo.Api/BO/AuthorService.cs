using AutoMapper;
using AutoMapper.QueryableExtensions;
using Biblo.Api.Configuration;
using Biblo.Api.Dto.Get;
using Biblo.DataLayer;
using Biblo.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblo.Api.BO
{
    public class AuthorService
    {
        private readonly BibloDbContext _bibloDbContext;

        public AuthorService(BibloDbContext bibloDbContext)
        {
            _bibloDbContext = bibloDbContext;
        }

        public IQueryable<AuthorDTO> Get()
        {
            return _bibloDbContext.Authors.ProjectTo<AuthorDTO>();
        }

        public AuthorDTO Find(int id)
        {
            AuthorDTO result = new AuthorDTO();
            var author = _bibloDbContext.Authors.First(a => a.id == id);
            Mapper.Map(author, result);
            return result;
        }
        public int Post(AuthorDTO authorDTO)
        {
            Author u = new Author();
            Mapper.Map(authorDTO, u);
            var result = _bibloDbContext.Authors.Add(u);
            _bibloDbContext.SaveChanges();
            return u.id;
        }
    }
}
