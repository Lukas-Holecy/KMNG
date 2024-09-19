// <copyright file="Program.cs" company="Lukas Holecy">
//     Copyright (c) Lukas Holecy. All rights reserved.
// </copyright>

namespace Holecy.Services;

using Holecy.Services.Controllers;
using Microsoft.AspNetCore.Mvc.Razor;

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

        var viewsPath = @"..\WebServer.Views\";
        _ = builder.Services.AddControllersWithViews()
            .AddApplicationPart(typeof(HomeController).Assembly)
            .AddRazorRuntimeCompilation();
        _ = builder.Services.AddEndpointsApiExplorer();
        _ = builder.Services.AddSwaggerGen();

        // Configure Razor View Engine options
        _ = builder.Services.Configure<RazorViewEngineOptions>(options =>
            {
                options.ViewLocationFormats.Add(viewsPath);
            });

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