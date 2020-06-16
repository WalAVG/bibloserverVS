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
    public class UserService
    {
        private readonly BibloDbContext _bibloDbContext;

        public UserService(BibloDbContext bibloDbContext)
        {
            _bibloDbContext = bibloDbContext;
        }
        public IQueryable<UserDTO> Get()
        {
            return _bibloDbContext.Users.ProjectTo<UserDTO>();
        }

        public int Post(UserDTO userDTO)
        {
            User u = new User();
            Mapper.Map(userDTO, u);
            var result = _bibloDbContext.Users.Add(u);
            _bibloDbContext.SaveChanges();
            return u.id;
        }

        public int Put(UserDTO userDTO)
        {
            User u = new User();
            Mapper.Map(userDTO, u);
            var result = _bibloDbContext.Users.Update(u);
            _bibloDbContext.SaveChanges();
            return 1;
        }

    }
}
