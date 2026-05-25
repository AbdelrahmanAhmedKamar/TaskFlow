using FluentValidation;
using TaskFlow.Application.Projects.Commands.UpdateTask;

namespace TaskFlow.Application.Projects.Commands.UpdateTask;

public class UpdateTaskCommanddValidator : AbstractValidator<UpdateTaskCommand>
{
    public UpdateTaskCommanddValidator()
    {
        RuleFor(x => x.Status).NotEmpty();
    }
}