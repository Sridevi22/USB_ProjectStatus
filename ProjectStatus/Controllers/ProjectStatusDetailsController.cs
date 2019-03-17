using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectStatus.Models;
using System;

namespace ProjectStatus.Controllers
{
    [Route("api/ProjectStatusDetails")]
    [ApiController]
    public class ProjectStatusDetailsController : ControllerBase
    {
        private readonly ProjectStatusDetailContext _context;
        private readonly ProjectDetailContext _projectDetailContext;

        public ProjectStatusDetailsController(ProjectStatusDetailContext context, ProjectDetailContext projectDetailContext)
        {
            _context = context;
            _projectDetailContext = projectDetailContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjectStatusDetail>>> GetProjectStatusDetail()
        {
            return await _context.ProjectStatusDetail.ToListAsync();
        }

        // POST: api/Todo
        [HttpPost]
        public async Task<ActionResult<ProjectDetail>> PostCreateProject(ProjectStatusDetail item)
        {
            try
            {
                _context.ProjectStatusDetail.Add(item);
                await _context.SaveChangesAsync();  
            }
            catch(Exception ex)
            {

            }
            return CreatedAtAction(nameof(GetProjectStatusDetail), new { id = item.ProjectID }, item);
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectStatusDetail>> GetProjectStatusDetail(long id)
        {
            var projectStatus = await _context.ProjectStatusDetail.FindAsync(id);

            if (projectStatus == null)
            {
                return NotFound();
            }

            return projectStatus;
        }
    }
}