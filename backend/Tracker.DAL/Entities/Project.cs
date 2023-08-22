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
    public class Project
    {
        private DateTime _created;

        public Project()
        {
            Created = Updated = DateTime.Now;
        }

        [Key]
        public Guid Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClusterId { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created
        {
            get => _created;
            set => _created = (value == DateTime.MinValue) ? DateTime.Now : value;
        }
        public DateTime Updated { get; set; }
    }
}
