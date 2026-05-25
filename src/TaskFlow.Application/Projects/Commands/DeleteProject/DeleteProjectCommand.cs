using MediatR;

namespace TaskFlow.Application.Projects.Command.DeleteProject;

public sealed record DeleteProjectCommand(Guid Id) : IRequest;