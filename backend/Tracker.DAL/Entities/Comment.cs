using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.DAL.Entities
{
    public class Comment
    {
        private DateTime _created;

        public Comment()
        {
            Created = Updated = DateTime.Now;
        }

        [Key]
        public Guid Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClusterId { get; set; }

        public string Text { get; set; }
        public DateTime Created
        {
            get => _created;
            set => _created = (value == DateTime.MinValue) ? DateTime.Now : value;
        }
        public DateTime Updated { get; set; }

        [ForeignKey("Id")]
        public Bug Bug { get; set; }
        [ForeignKey("Id")]
        public User Author { get; set; }
    }
}
