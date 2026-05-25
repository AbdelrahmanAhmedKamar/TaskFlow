using MediatR;
using Microsoft.EntityFrameworkCore;
using TaskFlow.Application.Common.Exceptions;
using TaskFlow.Application.Common.Interfaces;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Application.Projects.Queries.GetTasksByProjectId;

public sealed class GetTasksByProjectIdQueryHandler(IAppDbContext context) : IRequestHandler<GetTaskByProjectIdQuery, List<ProjectTask>>
{
    public async Task<List<ProjectTask>> Handle(GetTaskByProjectIdQuery request, CancellationToken cancellationToken)
    {
        var project = await context.Projects.FindAsync([request.Id], cancellationToken);

        if (project is null)
            throw new NotFoundException(nameof(Project), request.Id);

        var tasks= await context.Tasks.Where(t => t.ProjectId == request.Id).ToListAsync(cancellationToken);

        return tasks;
    }
}