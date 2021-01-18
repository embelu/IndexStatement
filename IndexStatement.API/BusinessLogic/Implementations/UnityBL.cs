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
    public class UnityBL : IUnityBL
    {
        private readonly IUnityRepository _UnityRepository;

        public UnityBL(IUnityRepository UnityRepository)
        {
            _UnityRepository = UnityRepository;
        }

        public int Delete(int id)
        {
            return _UnityRepository.Delete(id);
        }

        public UnityDTO GetById(int id)
        {
            var Unity = _UnityRepository.GetById(id);

            return Unity == null ? null : UnityMapper.UnityToDTO(Unity);
        }

        public IEnumerable<UnityDTO> GetAll()
        {
            var Unitys = _UnityRepository.GetAll();
            List<UnityDTO> UnityDTOs = new List<UnityDTO>();

            foreach (var item in Unitys)
            {
                UnityDTOs.Add(UnityMapper.UnityToDTO(item));
            }

            return UnityDTOs;

        }

        public int Post(UnityDTO UnityDTO)
        {
            return _UnityRepository.Post(UnityMapper.UnityFromDTO(UnityDTO));
        }

        public UnityDTO Put(int id, UnityDTO UnityDTO)
        {
            var UnityToUpdate = _UnityRepository.GetById(id);
            UnityToUpdate.Label = UnityDTO.Label;

            return UnityMapper.UnityToDTO(_UnityRepository.Put(UnityToUpdate));
        }
    }
}
