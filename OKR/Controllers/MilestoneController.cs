using Microsoft.AspNetCore.Mvc;
using OKR.Repository.Interface;

namespace OKR.Controllers
{
    public class MilestoneController : Controller
    {
        private readonly IProjectRepositroy prepo;
        private readonly IMilestoneRepository mrepo;
        private readonly IMilestoneTaskRepository trepo;
        private readonly IMilestoneSubTaskRepository srepo;

        public MilestoneController(IProjectRepositroy prepo, IMilestoneRepository mrepo, IMilestoneTaskRepository trepo, IMilestoneSubTaskRepository srepo)
        {
            this.prepo = prepo;
            this.mrepo = mrepo;
            this.trepo = trepo;
            this.srepo = srepo;
        }
        public IActionResult Index()
        {
            return View();
        }


    }
}
