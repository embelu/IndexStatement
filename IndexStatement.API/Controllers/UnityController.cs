using IndexStatement.API.BusinessLogic.Interfaces;
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
    public class UnityController : ControllerBase
    {
        private readonly IUnityBL _UnityBL;

        public UnityController(IUnityBL UnityBL)
        {
            _UnityBL = UnityBL;
        }

        // GET: api/<UnityController>
        [HttpGet]
        public IEnumerable<UnityDTO> GetAll()
        {
            return _UnityBL.GetAll();
        }

        // GET api/<UnityController>/5
        [HttpGet("{id}")]
        public UnityDTO GetById(int id)
        {
            var UnityDTO = _UnityBL.GetById(id);

            return UnityDTO;
        }

        // POST api/<UnityController>
        [HttpPost]
        public int Post([FromBody] UnityDTO UnityDTO)
        {
            return _UnityBL.Post(UnityDTO);
        }

        // PUT api/<UnityController>/5
        [HttpPut("{id}")]
        public UnityDTO Put(int id, [FromBody] UnityDTO UnityDTO)
        {
            return _UnityBL.Put(id, UnityDTO);
        }

        // DELETE api/<UnityController>/5
        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return _UnityBL.Delete(id);
        }
    }
}
