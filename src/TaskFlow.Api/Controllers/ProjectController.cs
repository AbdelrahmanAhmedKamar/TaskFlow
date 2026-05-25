using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskFlow.Api.Requests;
using TaskFlow.Application.Projects.Command.DeleteProject;
using TaskFlow.Application.Projects.Commands.CreateProject;
using TaskFlow.Application.Projects.Commands.UpdateProject;
using TaskFlow.Application.Projects.Queries.GetProjectById;
using TaskFlow.Application.Projects.Queries.GetProjects;

namespace TaskFlow.Api.Controllers;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
[Authorize]
public class ProjectController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await mediator.Send(new GetProjectsQuery());
        return Ok(result);
    }

    [HttpGet("{id:guid}", Name = "GetProjectById")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await mediator.Send(new GetProjectByIdQuery(id));
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateProjectRequest request)
    {
        var command = new CreateProjectCommand(request.Name, request.Description);
        var projectId = await mediator.Send(command);

        return CreatedAtRoute("GetProjectById", new { projectId }, null);
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Put(Guid id, UpdateProjectRequest request)
    {
        var command = new UpdateProjectCommand(id, request.Name, request.Description);

        await mediator.Send(command);

        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var command = new DeleteProjectCommand(id);

        await mediator.Send(command);

        return NoContent();
    }
}
