#pragma warning disable 8618

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.Common.DTO
{
    public class BugDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public UserDTO Author { get; set; }
        public ProjectDTO Project { get; set; }
        public int Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public ICollection<TagDTO> Tags { get; set; }
        public ICollection<UserDTO> Assignees { get; set; }
        public ICollection<CommentDTO> Comments { get; set; }
    }
}
