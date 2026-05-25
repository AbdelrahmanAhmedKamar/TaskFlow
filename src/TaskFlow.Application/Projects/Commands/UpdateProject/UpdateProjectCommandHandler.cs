using MediatR;
using TaskFlow.Application.Common.Exceptions;
using TaskFlow.Application.Common.Interfaces;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Application.Projects.Commands.UpdateProject;

public sealed class UpdateProjectCommandHandler(IAppDbContext context) : IRequestHandler<UpdateProjectCommand>
{
    public async Task Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
    {
        var project = await context.Projects.FindAsync([request.Id], cancellationToken);

        if (project is null)
            throw new NotFoundException(nameof(Project), request.Id);

        project.Name = request.Name;
        project.Description = request.Description;

        await context.SaveChangesAsync(cancellationToken);

    }
}