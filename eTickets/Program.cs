using eTickets.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//DbContext Configuration

//bnwsl been l context w l database (l code we are creating in c# and database (sql))
/*opt =>
//     .UseSqlServer(builder.Configuration.GetConnectionString("WebApiDatabase"))
{
    opt.UseMySql(builder.Configuration.GetConnectionString("WebApiDatabase"), new MariaDbServerVersion(new Version(10, 5, 5)),
                 mysqlOpts =>
                 {
                     mysqlOpts.UseNetTopologySuite();
                     mysqlOpts.CommandTimeout((int)TimeSpan.FromMinutes(3).TotalSeconds);
                 })
             //.UseLoggerFactory(loggerFactory)
             .EnableSensitiveDataLogging()
             .EnableDetailedErrors();
}*/
builder.Services.AddDbContext<AppDbContext>();


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
