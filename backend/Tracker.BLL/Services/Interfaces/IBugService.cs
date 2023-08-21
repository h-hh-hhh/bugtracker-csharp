using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.Common.DTO;

namespace Tracker.BLL.Services.Interfaces
{
    public interface IBugService : IService
    {
        public Task<ICollection<BugDTO>> GetAllBugs();
        public Task<BugDTO> GetBug(Guid id);
        public Task<BugDTO> CreateBug(BugCreateDTO dto);
        public Task<BugDTO> UpdateBug(BugCreateDTO dto, Guid authorId); // authorId from jwt
        public Task DeleteBug(Guid bugId, Guid authorId);
    }
}
