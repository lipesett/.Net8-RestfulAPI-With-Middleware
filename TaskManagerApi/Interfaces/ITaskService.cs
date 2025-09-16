using TaskManagerApi.Models;

namespace TaskManagerApi.Interfaces
{
    public interface ITaskService
    {
        Task<TaskItem?> GetTaskByIdAsync(int id);
        Task<IEnumerable<TaskItem>> GetAllTasksAsync();
        Task<TaskItem> CreateTaskAsync(TaskItem task);
        Task UpdateAsync(int Id, TaskItem task);
        Task DeleteAsync(int id);
    }
}
