using AutoMapper.QueryableExtensions;
using Biblo.Api.Dto.Get;
using Biblo.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblo.Api.BO
{
    public class AddressService
    {
        private readonly BibloDbContext _bibloDbContext;

        public AddressService(BibloDbContext bibloDbContext)
        {
            _bibloDbContext = bibloDbContext;
        }
        public IQueryable<AddressDTO> Get()
        {
            return _bibloDbContext.Addresses.ProjectTo<AddressDTO>();
        }
    }
}
