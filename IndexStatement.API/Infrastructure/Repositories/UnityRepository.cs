using IndexStatement.API.Entities;
using IndexStatement.API.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndexStatement.API.Infrastructure.Repositories
{
    public class UnityRepository : IUnityRepository
    {
        private readonly IndexStatementContext _context;

        public UnityRepository(IndexStatementContext indexStatementContext)
        {
            _context = indexStatementContext;
        }

        public int Delete(int id)
        {
            _context.Remove(_context.Unities.Find(id));
            _context.SaveChanges();
            return id;
        }

        public Unity GetById(int id)
        {
            return _context.Unities.Find(id);
        }

        public IEnumerable<Unity> GetAll()
        {
            return _context.Unities;
        }

        public int Post(Unity Unity)
        {
            _context.Add(Unity);
            _context.SaveChanges();
            return Unity.Id;
        }

        public Unity Put(Unity Unity)
        {
            _context.Update(Unity);
            _context.SaveChanges();
            return Unity;
        }
    }
}
