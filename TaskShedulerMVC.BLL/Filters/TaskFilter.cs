using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TaskShedulerMVC.DAL.Models;

namespace TaskShedulerMVC.BLL.Filters
{
    public class TaskFilter
    {
        public string Name { get; set; }
        public Expression<Func<TaskShedul, bool>> Expression { get; set; }
    }
}
