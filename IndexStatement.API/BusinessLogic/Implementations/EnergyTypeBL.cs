using IndexStatement.API.BusinessLogic.Interfaces;
using IndexStatement.API.Helpers;
using IndexStatement.API.Infrastructure.Interfaces;
using IndexStatement.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndexStatement.API.BusinessLogic.Implementations
{
    public class EnergyTypeBL : IEnergyTypeBL
    {
        private readonly IEnergyTypeRepository _energyTypeRepository;

        public EnergyTypeBL( IEnergyTypeRepository energyTypeRepository)
        {
            _energyTypeRepository = energyTypeRepository;
        }

        public int Delete(int id)
        {
            return _energyTypeRepository.Delete(id);
        }

        public EnergyTypeDTO GetById(int id)
        {
            var energyType = _energyTypeRepository.GetById(id);

            return energyType == null ? null : EnergyTypeMapper.EnergyTypeToDTO(energyType);
        }

        public IEnumerable<EnergyTypeDTO> GetAll()
        {
            var energyTypes = _energyTypeRepository.GetAll();
            List<EnergyTypeDTO> energyTypeDTOs = new List<EnergyTypeDTO>();  

            foreach (var item in energyTypes)
            {
                energyTypeDTOs.Add(EnergyTypeMapper.EnergyTypeToDTO(item)) ;
            }

            return energyTypeDTOs;

        }

        public int Post(EnergyTypeDTO energyTypeDTO)
        {
            return _energyTypeRepository.Post(EnergyTypeMapper.EnergyTypeFromDTO(energyTypeDTO));
        }

        public EnergyTypeDTO Put(int id, EnergyTypeDTO energyTypeDTO)
        {
            var energyTypeToUpdate = _energyTypeRepository.GetById(id);
            energyTypeToUpdate.Label = energyTypeDTO.Label;

            return  EnergyTypeMapper.EnergyTypeToDTO(_energyTypeRepository.Put(energyTypeToUpdate));
        }
    }
}
