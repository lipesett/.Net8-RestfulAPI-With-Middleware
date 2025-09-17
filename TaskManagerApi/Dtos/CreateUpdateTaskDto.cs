namespace TaskManagerApi.Dtos
{
    public class CreateUpdateTaskDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
