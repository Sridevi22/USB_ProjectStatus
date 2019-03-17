using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectStatus.Models;

namespace ProjectStatus.Controllers
{
    [Route("api/ProjectDetails")]
    [ApiController]
    public class ProjectDetailsController : ControllerBase
    {
        private readonly ProjectDetailContext _context;

        public ProjectDetailsController(ProjectDetailContext context)
        {
            _context = context;

            if (_context.ProjectDetails.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.ProjectDetails.Add(
                    new ProjectDetail
                    {
                        ProjectId = 1,
                        ProjectTitle = "Internal Transfers",
                        ProjectManagerName = "Sridevi N",
                        ProjectManagerID = 737329,
                        ProjectEndDate = "30-May-2019",
                        ResourceCount = 20
                    });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjectDetail>>> GetProjectDetail()
        {
            return await _context.ProjectDetails.ToListAsync();
        }

        // POST: api/Todo
        [HttpPost]
        public async Task<ActionResult<ProjectDetail>> PostCreateProject(ProjectDetail item)
        {
            _context.ProjectDetails.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProjectDetail), new { id = item.ProjectId }, item);
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectDetail>> GetProjectDetail(long id)
        {
            var projectDetail = await _context.ProjectDetails.FindAsync(id);

            if (projectDetail == null)
            {
                return NotFound();
            }

            return projectDetail;
        }
    }
}