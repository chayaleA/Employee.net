using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service.Services
{
    public class jobService : IJobService
    {
        private readonly IJobRepository _jobRepository;

        public jobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<List<Job>> GetListAsync()
        {
            return await _jobRepository.GetListAsync();
        }

        public async Task<Job> GetById(int id)
        {
            return await _jobRepository.GetById(id);
        }

        public async Task<Job> AddAsync(Job job)
        {

            return await _jobRepository.AddAsync(job);
        }

        public async Task<Job> UpdateAsync(int id, Job job)
        {
            return await _jobRepository.UpdateAsync(id, job);
        }

        public async Task RemoveAsync(int id)
        {
            await _jobRepository.RemoveAsync(id);
        }
    }
}
