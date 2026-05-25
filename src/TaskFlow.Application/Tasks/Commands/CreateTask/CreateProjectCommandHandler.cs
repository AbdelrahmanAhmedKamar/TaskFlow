using MediatR;
using TaskFlow.Application.Common.Interfaces;
using TaskFlow.Application.Projects.Commands.CreateTask;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Application.Projects.Commands.CreateProject;

public sealed class CreateTaskCommandHandler(IAppDbContext context) : IRequestHandler<CreateTaskCommand, Guid>
{
    public async Task<Guid> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
    {
        var task = new ProjectTask
        {
            Id = Guid.NewGuid(),
            ProjectId = request.ProjectId,
            Title = request.Title,
            Description = request.Description,
            Status = request.Status,
            Priority = request.Priority
        };

        context.Tasks.Add(task);

        await context.SaveChangesAsync(cancellationToken);

        return task.Id;
    }
}