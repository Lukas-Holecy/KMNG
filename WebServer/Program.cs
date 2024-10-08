// <copyright file="Program.cs" company="Lukas Holecy">
//     Copyright (c) Lukas Holecy. All rights reserved.
// </copyright>

namespace Holecy.Services;

using Holecy.Services.Views;
using Microsoft.Extensions.FileProviders;

/// <summary>
/// Represents the entry point of the application.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage(
    "Maintainability", "CA1515:Consider making public types internal", Justification = "Entry point of the application.")]
public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var viewsPath = Path.GetFullPath(@"../WebServer.Views/");
        _ = builder.Services.AddControllersWithViews()
            .AddApplicationPart(typeof(ViewsAssemblyMarker).Assembly)
            .AddRazorRuntimeCompilation(options =>
            {
                options.FileProviders.Add(new PhysicalFileProvider(viewsPath));
            });
        _ = builder.Services.AddEndpointsApiExplorer();
        _ = builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            _ = app.UseSwagger();
            _ = app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = "swagger";
            });
        }

        _ = app.UseHttpsRedirection();
        _ = app.UseAuthorization();
        _ = app.MapControllers();

        _ = app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}