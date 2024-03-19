using AutoMapper;
using EmployeeServer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.DTOs;
using Solid.Core.Services;
using Solid.Core.Entities;

namespace EmployeeServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _listEmployees;

        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeService listEmployees, IMapper mapper)
        {
            _listEmployees = listEmployees;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> Get()
        {
            return Ok(await _listEmployees.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> Get(int id)
        {
            return Ok(await _listEmployees.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EmployeePostModel employee)
        {
            var employeeToAdd = _mapper.Map<Employee>(employee);
            return Ok(await _listEmployees.AddAsync(employeeToAdd));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] EmployeePostModel employee)
        {
            var employeeToUpdate = _mapper.Map<Employee>(employee);
            return Ok(await _listEmployees.UpdateAsync(id, employeeToUpdate));
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _listEmployees.RemoveAsync(id);
        }
    }
}
