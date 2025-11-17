using Microsoft.EntityFrameworkCore;
using TareaFinal.Components;
using TareaFinal.Modelos;

var builder = WebApplication.CreateBuilder(args);

//conexion por defecto a la BD
string? connStr = builder.Configuration.GetConnectionString("DefaultConn");


// Agrega soporte para EF y la base de datos
builder.Services.AddDbContextFactory<AppDbContext>(options =>
        options.UseSqlServer(connStr));

builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();





// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
