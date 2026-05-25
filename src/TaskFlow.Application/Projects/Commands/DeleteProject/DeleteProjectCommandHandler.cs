using MediatR;
using TaskFlow.Application.Common.Exceptions;
using TaskFlow.Application.Common.Interfaces;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Application.Projects.Command.DeleteProject;

public sealed class DeleteProjectCommandHandler(IAppDbContext context) : IRequestHandler<DeleteProjectCommand>
{
    public async Task Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
    {
        var project = await context.Projects.FindAsync([request.Id], cancellationToken);

        if (project is null)
            throw new NotFoundException(nameof(Project), request.Id);

        context.Projects.Remove(project);

        await context.SaveChangesAsync(cancellationToken);

    }
}