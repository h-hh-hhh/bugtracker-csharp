using Microsoft.AspNetCore.Mvc;
using System.Xml;
using Tracker.BLL.Services;
using Tracker.BLL.Services.Interfaces;
using Tracker.Common.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tracker.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BugsController : ControllerBase
    {
        private readonly IBugService _bugService;
        public BugsController(IBugService bugService)
        {
            _bugService = bugService;
        }
        /// GET api/Bugs
        [HttpGet]
        public async Task<ActionResult<ICollection<BugDTO>>> Get()
        {
            return Ok(_bugService.GetAllBugs());
        }

        /// GET api/Bugs/dddddddd-dddd-dddd-dddd-dddddddddddd
        [HttpGet("{id}")]
        public async Task<ActionResult<BugDTO>> Get(Guid id)
        {
            return Ok(_bugService.GetBug(id));
        }

        /// POST api/Bugs
        [HttpPost]
        public async Task<ActionResult<BugDTO>> Post([FromBody] BugCreateDTO dto)
        {
            BugDTO returnDto = await _bugService.CreateBug(dto);
            return Created($"idkhowtoretrieveprefix{returnDto.Id}", returnDto); // TODO replace prefix
        }

        /// PUT api/Bugs
        [HttpPut()]
        public async Task<ActionResult<BugDTO>> Put([FromBody] BugCreateDTO dto)
        {
            return Ok(_bugService.UpdateBug(dto, new Guid("00000000-0000-0000-0001-000000000000"))); // TODO replace hardcoded authorid with actual auth
        }

        /// DELETE api/<BugsController>/dddddddd-dddd-dddd-dddd-dddddddddddd
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await _bugService.DeleteBug(id, new Guid("00000000-0000-0000-0001-000000000000")); // TODO replace hardcoded authorid with actual auth
            return NoContent();
        }
    }
}
