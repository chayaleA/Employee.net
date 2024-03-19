using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.DTOs;
using Solid.Core.Services;
using Solid.Core.Entities;
using EmployeeServer.Models;

namespace EmployeeServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class JobController : ControllerBase
    {
        private readonly IJobService _listJobs;

        private readonly IMapper _mapper;

        public JobController(IJobService listJobs, IMapper mapper)
        {
            _listJobs = listJobs;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Job>>> Get()
        {
            return Ok(await _listJobs.GetListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Job>> Get(int id)
        {
            return Ok(await _listJobs.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Job job)
        {
            return Ok(await _listJobs.AddAsync(job));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Job job)
        {
            return Ok(await _listJobs.UpdateAsync(id, job));
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _listJobs.RemoveAsync(id);
        }
    }
}
