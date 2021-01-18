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
        public ActionResult<IEnumerable<UnityDTO>> GetAll()
        {
            return Ok(_UnityBL.GetAll());
        }

        // GET api/<UnityController>/5
        [HttpGet("{id}")]
        public ActionResult<UnityDTO> GetById(int id)
        {
            var UnityDTO = _UnityBL.GetById(id);

            return Ok(UnityDTO);
        }

        // POST api/<UnityController>
        [HttpPost]
        public ActionResult<int> Post([FromBody] UnityDTO UnityDTO)
        {
            return Ok(_UnityBL.Post(UnityDTO));
        }

        // PUT api/<UnityController>/5
        [HttpPut("{id}")]
        public ActionResult<UnityDTO> Put(int id, [FromBody] UnityDTO UnityDTO)
        {
            return Ok(_UnityBL.Put(id, UnityDTO));
        }

        // DELETE api/<UnityController>/5
        [HttpDelete("{id}")]
        public ActionResult<int> Delete(int id)
        {
            return Ok(_UnityBL.Delete(id));
        }
    }
}
