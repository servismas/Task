using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TaskShedulerMVC.BLL.Services;

namespace TaskShedulerMVC.UI.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITaskService taskService;

        public TasksController(ITaskService _taskService)
        {
            taskService = _taskService;
        }

        public async Task<ActionResult> Index(int currentPage=1)
        {
            var tasks = await taskService.GetAllTasks();

            return View(tasks.ToPagedList(1, 10));
        }

        public string SomeAction() { return "Hello"; }

        public async Task<PartialViewResult> GetTask(string _taskDecscr)
        {
            var tasks = await taskService.GetAllTasks();
            var result = tasks.Where(x => x.Deskription.Contains(_taskDecscr));
            return PartialView("TaskView", result);
        }
    }
}