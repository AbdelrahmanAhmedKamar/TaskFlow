using TaskFlow.Domain.Tasks.Enums;

namespace TaskFlow.Api.Requests;

public class CreateTaskRequest
{
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Guid ProjectId { get; set; }

    public ProjectTaskStatus Status { get; set; }
    public TaskPriority Priority { get; set; }
}
