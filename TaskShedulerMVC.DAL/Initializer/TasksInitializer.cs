using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskShedulerMVC.DAL.Models;

namespace TaskShedulerMVC.DAL.Initializer
{
    public class TasksInitializer : DropCreateDatabaseAlways<TaskContext>
    {
        protected override void Seed(TaskContext context)
        {
            //            base.Seed(context);
            Category c1 = new Category() { Name = "Cat1" };
            Category c2 = new Category() { Name = "Cat2" };

            Mark m1 = new Mark() { Name = "Mark1" };
            Mark m2 = new Mark() { Name = "Mark2" };

            TaskShedul t1 = new TaskShedul() { Deskription = "descr1" };
            TaskShedul t2 = new TaskShedul() { Deskription = "descr2" };

            t1.Categories.Add(c1);
            t2.Categories.Add(c2);

            t1.Marks.Add(m1);
            t2.Marks.Add(m2);

            context.TaskSheduls.Add(t1);
            context.TaskSheduls.Add(t2);
            context.SaveChanges();
        }
    }
}
