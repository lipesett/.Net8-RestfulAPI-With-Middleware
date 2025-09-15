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
            return await _taskRepository.GetTaskByIdAsync(id);
        }
        public async Task UpdateAsync(TaskItem task)
        {
            // some business logic could go here
            var existingTask = await _taskRepository.GetTaskByIdAsync(task.Id);
            if (existingTask == null)
            {
                throw new Exception($"Task with ID {task.Id} not found.");
            }

            existingTask.Title = task.Title;
            existingTask.Description = task.Description;
            existingTask.IsCompleted = task.IsCompleted;

            await _taskRepository.UpdateAsync(existingTask);
        }
    }
}
