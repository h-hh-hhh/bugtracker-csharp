using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.Common.DTO;
using Tracker.DAL.Entities;

namespace Tracker.BLL.Configuration
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<BugCreateDTO, Bug>();
            CreateMap<Bug, BugDTO>();

            CreateMap<Comment, CommentDTO>();

            CreateMap<Project, ProjectDTO>();

            CreateMap<Tag, TagDTO>();

            CreateMap<User, UserDTO>();
        }
    }
}
