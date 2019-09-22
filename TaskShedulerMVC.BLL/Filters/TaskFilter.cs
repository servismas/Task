using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TaskShedulerMVC.BLL.Filters
{
    public class TaskFilter
    {
        string Name { get; set; }
        public Expression<Func<Task, bool>> Expression { get; set; }
    }
}
