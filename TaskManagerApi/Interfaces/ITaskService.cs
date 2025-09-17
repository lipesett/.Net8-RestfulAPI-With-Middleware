using TaskManagerApi.Dtos;
using TaskManagerApi.Models;

namespace TaskManagerApi.Interfaces
{
    public interface ITaskService
    {
        Task<TaskDto?> GetTaskByIdAsync(int id);
        Task<IEnumerable<TaskDto>> GetAllTasksAsync();
        Task<TaskDto> CreateTaskAsync(CreateUpdateTaskDto taskDto);
        Task UpdateAsync(int id, CreateUpdateTaskDto taskDto);
        Task DeleteAsync(int id);
    }
}
