using MediatR;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Application.Projects.Queries.GetProjects;

public sealed record GetProjectsQuery : IRequest<List<Project>>;
