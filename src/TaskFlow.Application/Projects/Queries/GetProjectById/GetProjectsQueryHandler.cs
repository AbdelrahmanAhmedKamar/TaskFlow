using MediatR;
using TaskFlow.Application.Common.Interfaces;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Application.Projects.Queries.GetProjectById;

public sealed class GetProjectByIdQueryHandler(IAppDbContext context) : IRequestHandler<GetProjectByIdQuery, Project?>
{
    public async Task<Project?> Handle(GetProjectByIdQuery request, CancellationToken cancellationToken)
    {
        return await context.Projects.FindAsync([request.Id], cancellationToken);
    }
}