using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.Common.DTO
{
    public class TagDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Color { get; set; } // format 0xaarrggbb
    }
}
