using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OKR.Models;
using OKR.Models.ViewModels;
using OKR.Repository.Interface;

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
