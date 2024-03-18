using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class JobDto
    {
        public string JobName { get; set; }

        public bool IsManager { get; set; }

        public DateTime startJob { get; set; }
    }
}
