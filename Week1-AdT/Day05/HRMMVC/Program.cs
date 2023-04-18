using ApplicationCore.Contract.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICandidateRepository, CandidateRepository>();
builder.Services.AddScoped<IEmployeeRequirementTypeRepository, EmployeeRequirementTypeRepository>();
builder.Services.AddScoped<IEmployeeTypeRepository, EmployeeTypeRepository>();
builder.Services.AddScoped<IJobCategoryRepository, JobCategoryRepository>();
builder.Services.AddScoped<IJobRequirementRepository, JobRequirementRepository>();
builder.Services.AddScoped<IStatusRepository, StatusRepository>();
builder.Services.AddScoped<ISubmissionRepository,SubmissionRepository>();
builder.Services.AddDbContext<RecruitingDbContext>(option =>{
    option.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    //this need for migrations
    option.UseSqlServer(builder.Configuration.GetConnectionString("RecruitingDb")); // this line of code help Program.cs locate the connection string in appsetting.json
});
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
