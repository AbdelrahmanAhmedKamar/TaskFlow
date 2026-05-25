using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskFlow.Api.Requests;
using TaskFlow.Api.Responses;
using TaskFlow.Application.Projects.Command.DeleteTask;
using TaskFlow.Application.Projects.Commands.CreateTask;
using TaskFlow.Application.Projects.Commands.UpdateTask;
using TaskFlow.Application.Projects.Queries.GetTasksByProjectId;

namespace TaskFlow.Api.Controllers;
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
[Authorize]
public class TasksController(IMediator mediator) : ControllerBase
{   


    [HttpGet("{projectId:guid}", Name = "GetTaskByProjectId")]
    public async Task<IActionResult> Get(Guid projectId)
    {
        var tasks = await mediator.Send(new GetTaskByProjectIdQuery(projectId));

        var response = tasks.Select(task => new TaskResponse
        {
            Id = task.Id,
            Title = task.Title,
            Description = task.Description,
            Status = task.Status.ToString(),
            Priority = task.Priority.ToString()
        });
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateTaskRequest request)
    {
        var command = new CreateTaskCommand(request.Title, request.Description, request.ProjectId, request.Status, request.Priority);
        var taskId = await mediator.Send(command);

        return CreatedAtRoute("GetTaskByProjectId", new { request.ProjectId }, null);
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Put(Guid id, UpdateTaskRequest request)
    {
        var command = new UpdateTaskCommand(id, request.Status);

        await mediator.Send(command);

        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var command = new DeleteTaskCommand(id);

        await mediator.Send(command);

        return NoContent();
    }
}
