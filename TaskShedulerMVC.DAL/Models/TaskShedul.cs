using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskShedulerMVC.DAL.Models
{
    public class TaskShedul
    {
        public TaskShedul()
        {
            Categories = new List<Category>();
            Marks = new List<Mark>();
        }
        [Key]
        public int Id { get; set; }
        public string Deskription { get; set; }
        public int Prioritet { get; set; }
        public DateTime? Deadline { get; set; }
        public bool IsDone { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }

    }
}
