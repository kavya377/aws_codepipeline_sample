using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from AWS CodePipeline + CodeBuild + EC2!");

app.MapGet("/health", () => "Application is running successfully.");

app.Run();
