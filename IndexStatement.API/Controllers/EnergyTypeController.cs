using IndexStatement.API.BusinessLogic.Interfaces;
using IndexStatement.API.Infrastructure.Interfaces;
using IndexStatement.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IndexStatement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnergyTypeController : ControllerBase
    {
        private readonly IEnergyTypeBL _energyTypeBL;

        public EnergyTypeController(IEnergyTypeBL energyTypeBL)
        {
            _energyTypeBL = energyTypeBL;
        }

        // GET: api/<EnergyTypeController>
        [HttpGet]
        public IEnumerable<EnergyTypeDTO> GetAll()
        {
            return _energyTypeBL.GetAll();
        }

        // GET api/<EnergyTypeController>/5
        [HttpGet("{id}")]
        public EnergyTypeDTO GetById(int id)
        {
            var energyTypeDTO = _energyTypeBL.GetById(id);

            return energyTypeDTO;
        }

        // POST api/<EnergyTypeController>
        [HttpPost]
        public int Post([FromBody] EnergyTypeDTO energyTypeDTO)
        {
            return _energyTypeBL.Post(energyTypeDTO);
        }

        // PUT api/<EnergyTypeController>/5
        [HttpPut("{id}")]
        public EnergyTypeDTO Put(int id, [FromBody] EnergyTypeDTO energyTypeDTO)
        {
            return _energyTypeBL.Put(id, energyTypeDTO);
        }

        // DELETE api/<EnergyTypeController>/5
        [HttpDelete("{id}")]
        public int Delete(int id)
        {
           return _energyTypeBL.Delete(id);
        }
    }
}
