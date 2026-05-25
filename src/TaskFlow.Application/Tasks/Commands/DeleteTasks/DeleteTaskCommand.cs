using MediatR;

namespace TaskFlow.Application.Projects.Command.DeleteTask;

public sealed record DeleteTaskCommand(Guid Id) : IRequest;