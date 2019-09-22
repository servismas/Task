namespace TaskShedulerMVC.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using TaskShedulerMVC.DAL.Initializer;
    using TaskShedulerMVC.DAL.Models;

    public class TaskContext : DbContext
    {
        // Your context has been configured to use a 'TaskContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TaskShedulerMVC.DAL.TaskContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TaskContext' 
        // connection string in the application configuration file.
        public TaskContext()
            : base("name=TaskContext")
        {
            //Database.SetInitializer(new TasksInitializer());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<TaskShedul> TaskSheduls { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}