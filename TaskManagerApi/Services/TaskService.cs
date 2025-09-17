using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TaskManagerApi.Dtos;
using TaskManagerApi.Exceptions;
using TaskManagerApi.Interfaces;
using TaskManagerApi.Models;

namespace TaskManagerApi.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IMapper _mapper;

        public TaskService(ITaskRepository taskRepository, IMapper mapper)
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<TaskDto>> GetAllTasksAsync()
        {
            var tasks = await _taskRepository.GetAllTasksAsync();
            return _mapper.Map<IEnumerable<TaskDto>>(tasks);
        }
        public async Task<TaskDto?> GetTaskByIdAsync(int id)
        {
            var task = await _taskRepository.GetTaskByIdAsync(id);
            if (task == null)
            { 
                throw new NotFoundException($"Task with ID {id} not found");
            }

            return _mapper.Map<TaskDto>(task);
        }

        public async Task<TaskDto> CreateTaskAsync(CreateUpdateTaskDto taskDto)
        {
            var task = _mapper.Map<TaskItem>(taskDto);
            var createdTask = await _taskRepository.CreateTaskAsync(task);
            return _mapper.Map<TaskDto>(createdTask);
        }

        public async Task UpdateAsync(int id, CreateUpdateTaskDto taskDto)
        {
            var existingTask = await _taskRepository.GetTaskByIdAsync(id);
            if (existingTask == null)
            {
                throw new NotFoundException($"Task with ID {id} not found.");
            }

            _mapper.Map(taskDto, existingTask);

            await _taskRepository.UpdateAsync(existingTask);
        }

        public async Task DeleteAsync(int id)
        {
            var taskToDelete = await _taskRepository.GetTaskByIdAsync(id);
            if (taskToDelete == null)
            {
                throw new NotFoundException($"Couldn't delete, because task with {id} was not found.");
            }

            await _taskRepository.DeleteAsync(id);
        }
    }
}
