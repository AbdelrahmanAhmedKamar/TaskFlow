using TaskFlow.Domain.Tasks.Enums;

namespace TaskFlow.Domain.Entities;

public class ProjectTask
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public Guid ProjectId { get; set; }

    public ProjectTaskStatus Status { get; set; }
    public TaskPriority Priority { get; set; }
    public Project Project { get; set; } = null!;
}