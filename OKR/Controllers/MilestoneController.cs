using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OKR.Models;
using OKR.Models.ViewModels;
using OKR.Repository.Implement;
using OKR.Repository.Interface;
using System.Linq;

namespace OKR.Controllers
{
    public class MilestoneController : Controller
    {
        private readonly IProjectRepositroy prepo;
        private readonly IEmployeeRepository erepo;
        private readonly IMilestoneRepository mrepo;
        private readonly IMilestoneTaskRepository trepo;
        private readonly IMilestoneSubTaskRepository srepo;
        private readonly ITeamMemberRepository tmrepo;

        public MilestoneController(IProjectRepositroy prepo, IEmployeeRepository erepo, ITeamMemberRepository tmrepo, IMilestoneRepository mrepo, IMilestoneTaskRepository trepo, IMilestoneSubTaskRepository srepo)
        {
            this.prepo = prepo;
            this.erepo = erepo;
            this.mrepo = mrepo;
            this.trepo = trepo;
            this.srepo = srepo;
            this.tmrepo = tmrepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        //public async Task<IActionResult> AddMember(string projectId)
        //{
        //    // Get the project from the repository
        //    var project = await tmrepo.GetById(projectId);

        //    // Get all employees
        //    var allEmployees = await erepo.GetAllAsync();

        //    // Get the IDs of employees already assigned to this project
        //    var assignedEmployeeIds = project.AssigneeId.ToList();

        //    // Filter out employees who are not already assigned to this project
        //    var assignedEmployeeGuids = assignedEmployeeIds.Select(Guid.Parse).ToList();
        //    var unassignedEmployees = allEmployees.Where(emp => !assignedEmployeeGuids.Contains(emp.Id)).ToList();

        //    ViewBag.UnassignedEmployees = new SelectList(unassignedEmployees, "Id", "EmpName");

        //    return View();
        //}

        //public async Task<IActionResult> AddMember()
        //{
        //    ViewBag.Assignee = new SelectList(await erepo.GetAllAsync(), "Id", "EmpName");
        //    return RedirectToAction("CreateMilestone");
        //}

        public IActionResult CreateMilestone()
        {
            var viewModel = new MilestoneViewModel();
            return View(viewModel);
        }


        //[HttpPost]
        //public async Task<IActionResult> CreateMilestone([FromBody]MilestoneViewModel item)
        //{
        //    var Milestone = new Milestone
        //    {
        //        Name = item.MilestoneName,
        //        Description = item.MilestoneDescription,
        //       // ProjectId = item.ProjectId,
        //    };
        //    await mrepo.Create(Milestone);
        //    var Task = new MilestoneTask
        //    {
        //        Name = item.TaskName,
        //        // Priority = item.Priority,
        //        // Dependency = item.Dependency,
        //        // Tag = item.Tag, 
        //        //Milestone = Milestone,
        //        // MilestoneId = item.MilestoneId,
        //    };
        //    await trepo.Create(Task);
        //    var STask = new MilestoneSubTask
        //    {
        //        Name = item.SubTaskName,
        //        // IsCompleted = item.IsCompleted,
        //        //  MilestoneTask = Task,
        //        //MilestoneTaskId = item.MilestoneTaskId,
        //    };
        //    await srepo.Create(STask);

        //    return View();
        //}


        [HttpPost("CreateMilestone/{projectId}")]
        public IActionResult CreateMilestone(string projectId)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //// Find the project by ID
            //var project = prepo.GetById(projectId);

            //if (project == null)
            //{
            //    return NotFound("Project not found");
            //}

            //// Create milestones
            //foreach (var milestoneModel in milestones)
            //{
            //    var milestone = new Milestone
            //    {
            //        Name = milestoneModel.Name,
            //        Description = milestoneModel.Description,
            //        ProjectId = projectId, // Associate the milestone with the project
            //        MilestoneTasks = new List<MilestoneTask>()
            //    };

            //    // Create tasks
            //    foreach (var taskModel in milestoneModel.MilestoneTasks)
            //    {
            //        var task = new MilestoneTask
            //        {
            //            Name = taskModel.Name,
            //            SubTasks = new List<MilestoneSubTask>()
            //        };

            //        // Create subtasks
            //        foreach (var subtaskModel in taskModel.MilestoneSubTasks)
            //        {
            //            var subtask = new MilestoneSubTask
            //            {
            //                Name = subtaskModel.Name
            //            };
            //            task.SubTasks.Add(subtask);
            //        }

            //        milestone.MilestoneTasks.Add(task);
            //    }

            //    mrepo.Create(milestone);
            //}

            return Ok("Milestones created successfully");
        }


    }
}
