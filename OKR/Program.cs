using Microsoft.EntityFrameworkCore;
using OKR.Data;
using OKR.Repository.Implement;
using OKR.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(o => o.UseNpgsql(builder.Configuration.GetConnectionString("dbcs")).EnableSensitiveDataLogging());

builder.Services.AddTransient<IProjectRepositroy, ProjectRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<ITeamMemberRepository, TeamMemberRepository>();
builder.Services.AddTransient<IMilestoneRepository, MilestoneRepository>();
builder.Services.AddTransient<IMilestoneTaskRepository, MilestoneTaskRepository>();
builder.Services.AddTransient<IMilestoneSubTaskRepository, MilestoneSubTaskRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Project}/{action=Create}/{id?}");

app.Run();
