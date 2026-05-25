using MediatR;
using TaskFlow.Domain.Tasks.Enums;

namespace TaskFlow.Application.Projects.Commands.UpdateTask;

public sealed record UpdateTaskCommand(Guid Id, ProjectTaskStatus Status) : IRequest;