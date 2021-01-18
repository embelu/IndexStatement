using IndexStatement.API.Entities;
using IndexStatement.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndexStatement.API.Helpers
{
    public class EnergyTypeMapper
    {
        public static EnergyTypeDTO EnergyTypeToDTO (EnergyType energyType)
        {
            return new EnergyTypeDTO()
            {
                Id = energyType.Id,
                Label = energyType.Label
            };
        }

        public static EnergyType EnergyTypeFromDTO(EnergyTypeDTO energyTypeDTO)
        {
            return new EnergyType()
            {
                Id = energyTypeDTO.Id,
                Label = energyTypeDTO.Label
            };
        }
    }
}
