using MediatR;
using TaskFlow.Application.Common.Exceptions;
using TaskFlow.Application.Common.Interfaces;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Application.Projects.Command.DeleteTask;

public sealed class DeleteTaskCommandHandler(IAppDbContext context) : IRequestHandler<DeleteTaskCommand>
{
    public async Task Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
    {
        var task = await context.Tasks.FindAsync([request.Id], cancellationToken);

        if (task is null)
            throw new NotFoundException(nameof(ProjectTask), request.Id);

        context.Tasks.Remove(task);

        await context.SaveChangesAsync(cancellationToken);

    }
}