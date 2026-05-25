using MediatR;
using Microsoft.EntityFrameworkCore;
using TaskFlow.Application.Common.Interfaces;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Application.Projects.Queries.GetProjects;

public sealed class GetProjectsQueryHandler (IAppDbContext context): IRequestHandler<GetProjectsQuery, List<Project>>
{
    public async Task<List<Project>> Handle(GetProjectsQuery request, CancellationToken cancellationToken)
    {
        return await context.Projects.ToListAsync(cancellationToken);
    }
}