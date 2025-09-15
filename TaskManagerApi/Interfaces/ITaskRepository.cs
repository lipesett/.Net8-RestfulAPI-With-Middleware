using TaskManagerApi.Models;

namespace TaskManagerApi.Interfaces
{
    public interface ITaskRepository
    {
        Task<TaskItem?> GetTaskByIdAsync(int id);
        Task<IEnumerable<TaskItem>> GetAllTasksAsync();
        Task<TaskItem> CreateTaskAsync(TaskItem task);
        Task UpdateAsync(TaskItem task);
        Task DeleteAsync(int id);
    }
}