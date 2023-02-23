using CouchPoker.Game;
using CouchPoker.Hubs;
using CouchPoker.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<PokerGameContext>(opt =>
{
    opt.UseInMemoryDatabase(databaseName: "CouchPoker");
    opt.UseLazyLoadingProxies();
}, ServiceLifetime.Singleton);

builder.Services
    .AddSingleton<GameInitializer>()
    .AddSingleton<UnitOfWork>();

builder.Services.AddSignalR();
builder.Services.AddSignalRCore();

builder.Services.AddControllersWithViews();

builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapHub<GameBoardHub>("api/signalr/gameBoardHub");
app.MapHub<PlayerHub>("api/signalr/playerHub");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "api",
    pattern: "api/{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();