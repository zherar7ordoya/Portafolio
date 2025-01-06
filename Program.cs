using Microsoft.AspNetCore.Hosting.StaticWebAssets;

using Portafolio.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

/**
 * TIPOS DE SERVICIOS
 * Este concepto tiene m�s que ver con el tiempo de vida de una instancia.
 * 
 * Transient: (Transitorio)
 * Cada vez que se solicita un servicio, se crea una nueva instancia.
 * 
 * Scoped: (Delimitado)
 * Se crea una instancia por cada solicitud HTTP.
 * 
 * Singleton: (�nico)
 * Se crea una �nica instancia por aplicaci�n.
 */
builder.Services.AddTransient<IRepositorioProyectos, RepositorioProyectos>();
builder.Services.AddTransient<IServicioEmail, ServicioEmail>();

// Habilitar los recursos est�ticos
StaticWebAssetsLoader.UseStaticWebAssets(
    builder.Environment,
    builder.Configuration
);

// Construir la aplicaci�n.-....................................................
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
