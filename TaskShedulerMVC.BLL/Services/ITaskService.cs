using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskShedulerMVC.BLL.ModelsDTO;

namespace TaskShedulerMVC.BLL.Services
{
    public interface ITaskService
    {
        Task<ICollection<TaskShedulDTO>> GetAllTasks();

        Task AddTask(TaskShedulDTO task);
        Task EditTask(TaskShedulDTO task);
        Task RemoveTask(TaskShedulDTO task);

    }
}
