using MediatR;
using TaskFlow.Application.Common.Exceptions;
using TaskFlow.Application.Common.Interfaces;
using TaskFlow.Application.Projects.Commands.UpdateTask;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Application.Projects.Commands.UpdateProject;

public sealed class UpdateTaskCommandHandler(IAppDbContext context) : IRequestHandler<UpdateTaskCommand>
{
    public async Task Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
    {
        var project = await context.Tasks.FindAsync([request.Id], cancellationToken);

        if (project is null)
            throw new NotFoundException(nameof(Project), request.Id);

        project.Status = request.Status;

        await context.SaveChangesAsync(cancellationToken);

    }
}