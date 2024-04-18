using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OKR.Models;
using OKR.Models.ViewModels;
using OKR.Repository.Interface;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace OKR.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectRepositroy repo;
        private readonly IEmployeeRepository erepo;
        private readonly ITeamMemberRepository trepo;

        public ProjectController(IProjectRepositroy Repo, IEmployeeRepository Erepo, ITeamMemberRepository Trepo)
        {
            repo = Repo;
            erepo = Erepo;
            trepo = Trepo;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Assignee = new SelectList(await erepo.GetAllAsync(), "Id", "EmpName");
            return View();
        }

        public ContentResult projectList()
        {
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                MaxDepth = 64 // Adjust the depth according to your needs
            };

            var data = repo.GetProjectDetails("bafbf86f-366c-4858-8f01-432c01fed344");
            var jsonData = JsonSerializer.Serialize(data, options);
            return Content(jsonData, "application/json");
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]ProjectCreateViewModel item)
        {
                // Create a new Project instance
                var project = new Project
                {
                    ProjectName = item.ProjectName,
                   // FilePath = item.FilePath,
                    Description = item.Description
                };
                await repo.Create(project);

            foreach (var assigneeId in item.AssigneeId)
            {
                var teamMember = new TeamMember
                {
                    ProjectId = project.Id,
                    AssigneeId = assigneeId
                };
                await trepo.Create(teamMember);

            }
                return View();

        }

        public async Task<IActionResult> GetProjects()
        {
            var projects = await repo.GetAllAsync();
            return Ok(projects);
        }

    }
}
