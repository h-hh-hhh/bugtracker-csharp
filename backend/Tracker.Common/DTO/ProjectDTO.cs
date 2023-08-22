using System;
using System.Collections.Generic;
using System.Linq;
#pragma warning disable 8618

using System.Text;
using System.Threading.Tasks;

namespace Tracker.Common.DTO
{
    public class ProjectDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public UserDTO Author { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
