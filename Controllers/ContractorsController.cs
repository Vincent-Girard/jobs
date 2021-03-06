using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jobs.Models;
using jobs.Services;
using Microsoft.AspNetCore.Mvc;

namespace jobs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractorsController : ControllerBase
    {
        private readonly ContractorsService _cs;

        public ContractorsController(ContractorsService cs)
        {
            _cs = cs;
        }

        // GET api/bricks
        [HttpGet]
        public ActionResult<IEnumerable<Contractor>> Get()
        {
            try
            {
                return Ok(_cs.Get());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET api/Contractors/5
        [HttpGet("{id}")]
        public ActionResult<Contractor> Get(int id)
        {
            try
            {
                return Ok(_cs.Get(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST api/Contractors
        [HttpPost]
        public ActionResult<Contractor> Post([FromBody] Contractor newContractor)
        {
            try
            {
                return Ok(_cs.Create(newContractor));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // DELETE api/Contractors
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            try
            {
                return Ok(_cs.Delete(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
