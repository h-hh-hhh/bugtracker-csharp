#pragma warning disable 8618

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.DAL.Entities
{
    public class Bug
    {
        public enum StatusType
        {
            Open,
            ClosedResolved,
            Closed
        }

        private DateTime _created;

        public Bug()
        {
            Created = Updated = DateTime.Now;
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public StatusType Status { get; set; }
        public DateTime Created 
        {
            get => _created;
            set => _created = (value == DateTime.MinValue) ? DateTime.Now : value;
        }
        public DateTime Updated { get; set; }

        [ForeignKey("Author")]
        public Guid AuthorId { get; set; }
        public User Author { get; set; }
        [ForeignKey("Project")]
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public ICollection<User> Assignees { get; private set; }
        public ICollection<Tag> Tags { get; private set; }
    }
}
