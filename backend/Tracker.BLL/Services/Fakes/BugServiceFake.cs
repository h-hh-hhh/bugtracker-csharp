using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.BLL.Services.Interfaces;
using Tracker.Common.DTO;

namespace Tracker.BLL.Services.Fakes
{
    public class BugServiceFake : IBugService
    {
        private static UserDTO _user1 = new UserDTO
        {
            Id = new Guid("00000000-0000-0000-0001-000000000000"),
            Username = "h",
            Created = DateTime.Now,
            Updated = DateTime.Now
        };
        private static UserDTO _user2 = new UserDTO
        {
            Id = new Guid("00000000-0000-0000-0001-000000000001"),
            Username = "h2",
            Created = DateTime.Now,
            Updated = DateTime.Now
        };
        private static ProjectDTO _project = new ProjectDTO
        {
            Id = new Guid("00000000-0000-0000-0003-000000000000"),
            Name = "project 1",
            Description = "Description for project 1",
            Author = _user1,
            Created = DateTime.Now,
            Updated = DateTime.Now
        };
        private static TagDTO _tag1 = new TagDTO
        {
            Id = new Guid("00000000-0000-0000-0002-000000000000"),
            Name = "Tag 1",
            Color = 0x000057b7
        };
        private static TagDTO _tag2 = new TagDTO
        {
            Id = new Guid("00000000-0000-0000-0002-000000000001"),
            Name = "Tag 2",
            Color = 0x00ffd700
        };
        private static ICollection<BugDTO> _bugs = new List<BugDTO>
        {
            new BugDTO
            {
                Id = new Guid("00000000-0000-0000-0000-000000000000"),
                Title = "Test get",
                Description = "Description",
                Author = _user1,
                Project = _project,
                Status = 0,
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Tags = new List<TagDTO>
                {
                    _tag1,
                    _tag2
                },
                Assignees = new List<UserDTO>
                {
                    _user1,
                    _user2
                }
            },
            new BugDTO
            {
                Id = new Guid("00000000-0000-0000-0000-000000000001"),
                Title = "Test create",
                Description = "Description",
                Author = _user1,
                Project = _project,
                Status = 0,
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Tags = new List<TagDTO>
                {
                    _tag1,
                    _tag2
                },
                Assignees = new List<UserDTO>
                {
                    _user1,
                    _user2
                }
            },
            new BugDTO
            {
                Id = new Guid("00000000-0000-0000-0000-000000000002"),
                Title = "Test update",
                Description = "Description",
                Author = _user1,
                Project = _project,
                Status = 0,
                Created = DateTime.Now,
                Updated = DateTime.Now,
                Tags = new List<TagDTO>
                {
                    _tag1,
                    _tag2
                },
                Assignees = new List<UserDTO>
                {
                    _user1,
                    _user2
                }
            },
        };
        public async Task<BugDTO> CreateBug(BugCreateDTO dto)
        {
            return _bugs.ToList()[1];
        }

        public async Task DeleteBug(Guid bugId, Guid authorId)
        {
            return;
        }

        public async Task<ICollection<BugDTO>> GetAllBugs()
        {
            return _bugs;
        }

        public async Task<BugDTO> GetBug(Guid id)
        {
            return _bugs.ToList()[0];
        }

        public async Task<BugDTO> UpdateBug(BugCreateDTO dto, Guid authorId)
        {
            return _bugs.ToList()[2];
        }
    }
}
