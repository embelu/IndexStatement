using IndexStatement.API.Entities;
using IndexStatement.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndexStatement.API.Helpers
{
    public class UnityMapper
    {
        public static UnityDTO UnityToDTO(Unity Unity)
        {
            return new UnityDTO()
            {
                Id = Unity.Id,
                Label = Unity.Label
            };
        }

        public static Unity UnityFromDTO(UnityDTO UnityDTO)
        {
            return new Unity()
            {
                Id = UnityDTO.Id,
                Label = UnityDTO.Label
            };
        }
    }
}
