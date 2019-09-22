using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskShedulerMVC.DAL.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TaskShedulId { get; set; }
        public virtual TaskShedul TaskShedul { get; set; }
    }
}
