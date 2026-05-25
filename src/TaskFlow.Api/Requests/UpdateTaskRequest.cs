using TaskFlow.Domain.Tasks.Enums;

namespace TaskFlow.Api.Requests;

public class UpdateTaskRequest
{
    public ProjectTaskStatus Status { get; set; }

}