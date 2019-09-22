using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskShedulerMVC.BLL.ModelsDTO;
using TaskShedulerMVC.DAL.Models;
using TaskShedulerMVC.DAL.Repository;

namespace TaskShedulerMVC.BLL.Services
{
    public class TaskService : ITaskService
    {
        private readonly IRepository<TaskShedul> repository;
        private readonly IMapper mapper;
        public TaskService(IRepository<TaskShedul> _repository, IMapper _mapper)
        {
            repository = _repository;
            mapper = _mapper;
        }
        public async Task<ICollection<TaskShedulDTO>> GetAllTasks()
        {
            var tasks = await repository.GetAll();
            return mapper.Map<IEnumerable<TaskShedul>, ICollection<TaskShedulDTO>>(tasks);

        }
        public Task AddTask(TaskShedulDTO task)
        {
            throw new NotImplementedException();
        }

        public Task EditTask(TaskShedulDTO task)
        {
            throw new NotImplementedException();
        }


        public Task RemoveTask(TaskShedulDTO task)
        {
            throw new NotImplementedException();
        }
    }
}
