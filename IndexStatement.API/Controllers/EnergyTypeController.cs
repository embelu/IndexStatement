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
        public ActionResult<IEnumerable<EnergyTypeDTO>> GetAll()
        {
            return Ok(_energyTypeBL.GetAll());
        }

        // GET api/<EnergyTypeController>/5
        [HttpGet("{id}")]
        public ActionResult<EnergyTypeDTO> GetById(int id)
        {
            var energyTypeDTO = _energyTypeBL.GetById(id);

            return Ok(energyTypeDTO);
        }

        // POST api/<EnergyTypeController>
        [HttpPost]
        public ActionResult<int> Post([FromBody] EnergyTypeDTO energyTypeDTO)
        {
            return Ok(_energyTypeBL.Post(energyTypeDTO));
        }

        // PUT api/<EnergyTypeController>/5
        [HttpPut("{id}")]
        public ActionResult<EnergyTypeDTO> Put(int id, [FromBody] EnergyTypeDTO energyTypeDTO)
        {
            return Ok(_energyTypeBL.Put(id, energyTypeDTO));
        }

        // DELETE api/<EnergyTypeController>/5
        [HttpDelete("{id}")]
        public ActionResult<int> Delete(int id)
        {
           return Ok(_energyTypeBL.Delete(id));
        }
    }
}
