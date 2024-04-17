using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public async Task<IActionResult> AddMember()
        {
            ViewBag.Assignee = new SelectList(await erepo.GetAllAsync(), "Id", "EmpName");
            return View();
        }

        public IActionResult CreateMilestone()
        {
            var viewModel = new MilestoneViewModel();
            return View(viewModel);
        }


        [HttpPost]
        public async Task<IActionResult> SaveMilestoneData(MilestoneViewModel item)
        {
            //if (ModelState.IsValid)
            //{
            //    // Save milestone data
            //    milestone.ProjectId = projectId;
            //    await mrepo.Create(milestone);

            //    // Save milestone task data
            //    foreach (var task in milestoneTasks)
            //    {
            //        task.MilestoneId = milestone.Id;
            //        await trepo.Create(task);
            //    }

            //    // Save milestone subtask data
            //    foreach (var subtask in milestoneSubTasks)
            //    {
            //        subtask.MilestoneTaskId = milestone.Id;
            //        await srepo.Create(subtask);
            //    }

            //   return RedirectToAction(nameof(EditContext), new { id = projectId });
            //}

            //// If model state is not valid, return to the form view
            //// with the model data so user can correct errors
            //ViewBag.ProjectId = projectId;
            //return View("CreateMilestone", new MilestoneViewModel
            //{
            //    Milestone = milestone,
            //    MilestoneTasks = milestoneTasks,
            //    MilestoneSubTasks = milestoneSubTasks
            //});
            //}
            return Json(item);
        }

    }
}
