using FluentValidation;
using TaskFlow.Application.Projects.Commands.CreateTask;

namespace TaskFlow.Application.Projects.Commands.CreateProject;

public class CreateTaskCommandValidator : AbstractValidator<CreateTaskCommand>
{
    public CreateTaskCommandValidator()
    {
        RuleFor(x => x.ProjectId).NotEmpty();
        RuleFor(x => x.Status).NotEmpty();
        RuleFor(x => x.Priority).NotEmpty();
        RuleFor(x => x.Title).NotEmpty().WithMessage("Title should not be empty");
    }
}