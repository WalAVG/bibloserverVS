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
    public class InsertingService
    {
        private readonly BibloDbContext _bibloDbContext;

        public InsertingService(BibloDbContext bibloDbContext)
        {
            _bibloDbContext = bibloDbContext;
        }
        public IQueryable<InsertingDTO> Get()
        {
            return _bibloDbContext.Insertings.ProjectTo<InsertingDTO>();
        }
        public InsertingDTO Find(int id)
        {
            InsertingDTO result = new InsertingDTO();
            var inserting = _bibloDbContext.Insertings.First(a => a.id == id);
            Mapper.Map(inserting, result);
            return result;
        }
        public int Post(InsertingDTO insertingDTO)
        {
            Inserting u = new Inserting();
            Mapper.Map(insertingDTO, u);
            var result = _bibloDbContext.Insertings.Add(u);
            _bibloDbContext.SaveChanges();
            return u.id;
        }
        public int Delete(InsertingDTO insertingDTO)
        {
            Inserting u = new Inserting();
            Mapper.Map(insertingDTO, u);
            var result = _bibloDbContext.Insertings.Remove(u);
            _bibloDbContext.SaveChanges();
            return u.id;
        }
        public int Put(InsertingDTO insertingDTO)
        {
            Inserting u = new Inserting();
            Mapper.Map(insertingDTO, u);
            var result = _bibloDbContext.Insertings.Update(u);
            _bibloDbContext.SaveChanges();
            return 1;
        }


    }
}
