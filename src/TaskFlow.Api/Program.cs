
using Scalar.AspNetCore;
using TaskFlow.Api;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationServices(builder.Configuration);

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
        app.UseDeveloperExceptionPage();
}
app.UseExceptionHandler();

app.UseStatusCodePages();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

if (app.Environment.IsDevelopment())
{
        app.MapOpenApi();

        app.UseSwaggerUI(options =>
        {
                options.SwaggerEndpoint("/openapi/v1.json", "Project API V1");
                options.SwaggerEndpoint("/openapi/v2.json", "Project API V2");

                options.EnableDeepLinking();
                options.DisplayRequestDuration();
                options.EnableFilter();
        });

        app.MapScalarApiReference();
}


app.Run();

