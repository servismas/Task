using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskShedulerMVC.BLL.ModelsDTO;
using TaskShedulerMVC.DAL.Models;

namespace TaskShedulerMVC.BLL.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<TaskShedul, TaskShedulDTO>();
            CreateMap<Mark, MarkDTO>();
            CreateMap<Category, CategoryDTO>();
        }
    }
}
