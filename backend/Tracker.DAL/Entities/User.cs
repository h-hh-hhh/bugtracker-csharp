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
    public class User
    {
        private DateTime _created;

        public User()
        {
            Created = Updated = DateTime.Now;
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Salt { get; set; }
        public DateTime Created
        {
            get => _created;
            set => _created = (value == DateTime.MinValue) ? DateTime.Now : value;
        }
        public DateTime Updated { get; set; }

        public ICollection<Bug> AssignedBugs { get; set; }
    }
}
