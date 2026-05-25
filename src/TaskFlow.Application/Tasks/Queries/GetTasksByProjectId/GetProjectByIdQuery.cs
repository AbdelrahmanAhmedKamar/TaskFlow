using MediatR;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Application.Projects.Queries.GetTasksByProjectId;

public sealed record GetTaskByProjectIdQuery(Guid Id) : IRequest<List<ProjectTask>>;