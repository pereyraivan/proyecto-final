using Application;
using Infrastrusture;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddInfrastructure(connectionString);

builder.Services.AddControllers();

builder.Services.AddCors(options => 
options.AddPolicy("Default",
                            policy =>
                            {
                                policy.AllowAnyOrigin()
                                .AllowAnyHeader()
                                .AllowAnyMethod();
                            }));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.InstallApplication();
builder.Services.InstallRepositories();

var app = builder.Build();



app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.UseCors("Default");

app.MapControllers();

app.Run();
