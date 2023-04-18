using WebApplication1;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//middleware
app.Use(async (context, next) =>
{
    if (context.Request.Method == HttpMethods.Get 
    && context.Request.Query["custom"] == "true")
    {
        if (!context.Response.HasStarted)
        {
            context.Response.ContentType = "text/plain";
        }
        await context.Response.WriteAsync("Custom parameter targeted middleware \n");
    }
    await next();
    await context.Response.WriteAsync($"\nStatus Code: {context.Response.StatusCode}");
    await context.Response.WriteAsync("On my way out from Class Middleware \n");
});

app.MapGet("/", () => "Hello World");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.UseMiddleware<QueryStringMiddleWare>();

app.Run(async(context) =>
{
    await context.Response.WriteAsync("Terminal MiddleWare \n");
});
app.Run(); //terminal middleware
