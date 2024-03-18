using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Entities
{
    public class Job
    {
        public int Id { get; set; }

        public string JobName { get; set; }

        public bool IsManager { get; set; }

        public DateTime startJob { get; set; }

    }
}
