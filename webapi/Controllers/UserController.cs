using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webapi.Dto;
using webapi.Models;
using webapi.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapi.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly Irepository<User, UserData> _repository;

        public UserController(IMapper mapper, Irepository<User, UserData> irepository)
        {
            _mapper = mapper;
            _repository = irepository;
        }

        // GET: api/<UserController>
        [HttpGet]
        public ICollection<User> Get()
        {
            var result = _repository.Get();
            return result.ToList();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            
            var result = _repository.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data!);
            }

            return StatusCode(result.StatusCode, result);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<ActionResult<User>> Post([FromBody] UserData postData)
        {
            var result = await _repository.Create(postData);
            
            return StatusCode(result.StatusCode, result);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public Task<ActionResult> Put(int id, [FromBody] UserData putData)
        {
            var result = _repository.Update(putData);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return StatusCode(result.StatusCode, result);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public Task<ActionResult> Delete(int id)
        {
            var result = _repository.Delete(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return StatusCode(result.StatusCode, result);
        }
    }
}
