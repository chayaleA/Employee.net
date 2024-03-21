using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Solid.Data.Repositories
{
    public class JobRepository: IJobRepository
    {
        private readonly DataContext _dataJob;

        public JobRepository(DataContext dataJob)
        {
            _dataJob = dataJob;
        }

        public async Task<List<Job>> GetListAsync()
        {
            return await _dataJob.JobsList.ToListAsync();
        }

        public async Task<Job> GetById(int id)
        {
            return await _dataJob.JobsList.FindAsync(id);
        }

        public async Task<Job> AddAsync(Job job)
        {
            _dataJob.JobsList.AddAsync(job);
            await _dataJob.SaveChangesAsync();
            return job;
        }

        public async Task<Job> UpdateAsync(int id, Job job)
        {
            Job temp = await GetById(id);
            _dataJob.Entry(temp).CurrentValues.SetValues(job);  
            await _dataJob.SaveChangesAsync();
            return job;
        }

        public async Task RemoveAsync(int id)
        {
            Job temp = await GetById(id);
            if (temp != null)
                _dataJob.JobsList.Remove(temp);
            await _dataJob.SaveChangesAsync();
        }
    }
}
