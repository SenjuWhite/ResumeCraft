using Microsoft.EntityFrameworkCore;
using ResumeCraft_API.DataAccess;
using ResumeCraft_API.DataAccess.UnitOfWork;
using ResumeCraft_API.Services.IServices;
using ResumeCraft_API.Services;
using ResumeCraft_API.Mappings;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentVariables();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
//Console.WriteLine($"Connection string: {connectionString}");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(ResumeProfile));
builder.Services.AddScoped(typeof(IResumeSectionService<>), typeof(ResumeSectionService<>));
builder.Services.AddScoped<IResumeService, ResumeService>();
builder.Services.AddScoped<ITemplateService, TemplateService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
