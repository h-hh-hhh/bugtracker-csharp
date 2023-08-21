using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.BLL.Services.Interfaces;
using Tracker.Common.DTO;

namespace Tracker.BLL.Services
{
    public class BugService : IService, IBugService
    {
        public Task<BugDTO> CreateBug(BugCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBug(Guid bugId, Guid authorId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<BugDTO>> GetAllBugs()
        {
            throw new NotImplementedException();
        }

        public Task<BugDTO> GetBug(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<BugDTO> UpdateBug(BugCreateDTO dto, Guid authorId)
        {
            throw new NotImplementedException();
        }
    }
}
