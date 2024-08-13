using AspNetCoreCleanArchitecture.Api;
using AspNetCoreCleanArchitecture.Application;
using AspNetCoreCleanArchitecture.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

builder.Services
    .AddApi(builder.Configuration)
    .AddApplication()
    .AddInfrastructure();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// TODO: This ugly part will be removed when this issue is fixed: https://github.com/dotnet/aspnetcore/issues/51888
app.UseExceptionHandler(_ => { });

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
