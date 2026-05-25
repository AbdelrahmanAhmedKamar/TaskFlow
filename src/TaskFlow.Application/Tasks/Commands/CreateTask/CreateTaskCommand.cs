using MediatR;
using TaskFlow.Domain.Tasks.Enums;

namespace TaskFlow.Application.Projects.Commands.CreateTask;

public sealed record CreateTaskCommand(string Title, string? Description, Guid ProjectId, ProjectTaskStatus Status, TaskPriority Priority) : IRequest<Guid>;