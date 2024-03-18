using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IJobService
    {
        Task<List<Job>> GetListAsync();

        Task<Job> GetById(int id);

        Task<Job> AddAsync(Job job);

        Task<Job> UpdateAsync(int id, Job job);

        Task RemoveAsync(int id);
    }
}
