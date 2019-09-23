using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TaskShedulerMVC.BLL.Filters;
using TaskShedulerMVC.BLL.ModelsDTO;
using TaskShedulerMVC.BLL.Services;

namespace TaskShedulerMVC.UI.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITaskService taskService;
        private List<TaskFilter> TaskFilters;

        public TasksController(ITaskService _taskService)
        {
            taskService = _taskService;
        }

        public async Task<ActionResult> Index(int currentPage=1)
        {
            var tasks = await taskService.GetAllTasks();
            ViewBag.Category = new List<string>();
            foreach (var t in tasks)
            {
                foreach (var c in t.Categories)
                {
                    ViewBag.Category.Add(c.Name); // помінять
                }
            }


            return View(tasks.ToPagedList(1, 10));
        }

        public string SomeAction() { return "Hello"; }

        public async Task<PartialViewResult> GetTask(string _taskDecscr)
        {
            var tasks = await taskService.GetAllTasks();
            var result = tasks.Where(x => x.Deskription.Contains(_taskDecscr));
            return PartialView("TaskView", result);
        }
        public async Task<PartialViewResult> GetTaskByCategory(string _categoryName)
        {
            //if (Session["Filters"] != null)
            //{
            //    TaskFilters = Session["Filters"] as List<TaskFilter>;
            //}
            //else
            //{
            //    TaskFilters = new List<TaskFilter>();
            //}

            //var filter = new TaskFilter
            //{

            //    Name = _categoryName,
            //    Expression = (
                
            //    x =>
            //    {
            //        foreach (var c in x.Categories)
            //        {
            //            if (c.Name == _categoryName) return c;
            //        }
            //    }
                
            //    x.Categories.ElementAt(0).Name == _categoryName)
            //    //{
            //    //    foreach(var c in x.Categories)
            //    //    {
            //    //        c.Name == _categoryName;

            //    //    }
            //    //})
            //};

            //TaskFilters.Add(filter);
            //Session["Filters"] = TaskFilters;



            var tasks = await taskService.GetAllTasks();
            List<TaskShedulDTO> result = new List<TaskShedulDTO>();
            foreach (var t in tasks)
            {
                foreach (var c in t.Categories)
                {
                    if (c.Name == _categoryName)
                    {
                        result.Add(t);
                        break;
                    }
                }
            }

            //var result = tasks.Where(x => x.Deskription.Contains(_taskDecscr));
            return PartialView("TaskView", result);
        }
    }
}