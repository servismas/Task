using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskShedulerMVC.BLL.ModelsDTO
{
    public class TaskShedulDTO
    {
        public int Id { get; set; }
        public string Deskription { get; set; }
        public int Prioritet { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsDone { get; set; }
        public ICollection<CategoryDTO> Categories { get; set; }
        public ICollection<MarkDTO> Marks { get; set; }
    }
}
