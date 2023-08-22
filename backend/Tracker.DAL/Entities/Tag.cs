#pragma warning disable 8618

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.DAL.Entities
{
    public class Tag
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public uint Color { get; set; }

        public ICollection<Bug> TaggedBugs { get; set; }
    }
}
