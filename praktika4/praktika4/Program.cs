using Microsoft.EntityFrameworkCore;
using praktika4.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ProniaDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "Default",
    pattern: "{Controller=Home}/{Action=Index}/{id?}"
    );



app.Run();
