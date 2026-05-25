using MediatR;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Application.Projects.Queries.GetProjectById;

public sealed record GetProjectByIdQuery(Guid Id) : IRequest<Project?>;