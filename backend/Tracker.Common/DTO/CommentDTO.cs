using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.Common.DTO
{
    public class CommentDTO
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public UserDTO Author { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
