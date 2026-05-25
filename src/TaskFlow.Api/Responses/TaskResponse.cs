using TaskFlow.Domain.Tasks.Enums;

namespace TaskFlow.Api.Responses
{
    public class TaskResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
    }
}
