using IndexStatement.API.Entities;
using IndexStatement.API.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndexStatement.API.Infrastructure.Repositories
{
    public class EnergyTypeRepository : IEnergyTypeRepository
    {
        private readonly IndexStatementContext _context;

        public EnergyTypeRepository(IndexStatementContext indexStatementContext)
        {
            _context = indexStatementContext;
        }

        public int Delete(int id)
        {
            _context.Remove(_context.EnergyTypes.Find(id));
            _context.SaveChanges();
            return id;
        }

        public EnergyType GetById(int id)
        {
            return _context.EnergyTypes.Find(id);
        }

        public IEnumerable<EnergyType> GetAll()
        {
            return _context.EnergyTypes;
        }

        public int Post(EnergyType energyType)
        {
            _context.Add(energyType);
            _context.SaveChanges();
            return energyType.Id;
        }

        public EnergyType Put(EnergyType energyType)
        {
            _context.Update(energyType);
            _context.SaveChanges();
            return energyType;
        }
    }
}
