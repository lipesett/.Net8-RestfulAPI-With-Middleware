using AutoMapper;
using TaskManagerApi.Dtos;
using TaskManagerApi.Models;

namespace TaskManagerApi.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TaskItem, TaskDto>();
            CreateMap<CreateUpdateTaskDto, TaskItem>();
        }
    }
}
