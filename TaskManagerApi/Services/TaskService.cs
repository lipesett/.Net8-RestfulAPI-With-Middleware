using TaskManagerApi.Exceptions;
using TaskManagerApi.Interfaces;
using TaskManagerApi.Models;

namespace TaskManagerApi.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<TaskItem> CreateTaskAsync(TaskItem task)
        {
            // if there was business logic to validate the task, it would go here
            // example: mandatory title, description, etc.
            return await _taskRepository.CreateTaskAsync(task);
        }

        public async Task DeleteAsync(int id)
        {
            await _taskRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<TaskItem>> GetAllTasksAsync()
        {
            return await _taskRepository.GetAllTasksAsync();
        }

        public async Task<TaskItem?> GetTaskByIdAsync(int id)
        {
            var task = await _taskRepository.GetTaskByIdAsync(id);
            
            if (task == null)
            {
                throw new NotFoundException($"Task with ID {id} not found");
            }

            return task;
        }

        public async Task UpdateAsync(int id, TaskItem task)
        {
            // some business logic could go here
            if (id != task.Id)
            {
                throw new BadRequestException("Route ID does not match request body ID.");
            }

            var existingTask = await _taskRepository.GetTaskByIdAsync(task.Id);

            if (existingTask == null)
            {
                throw new NotFoundException($"Task with ID {task.Id} not found.");
            }

            existingTask.Title = task.Title;
            existingTask.Description = task.Description;
            existingTask.IsCompleted = task.IsCompleted;

            await _taskRepository.UpdateAsync(existingTask);
        }
    }
}
