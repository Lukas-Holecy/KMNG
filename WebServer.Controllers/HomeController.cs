// <copyright file="HomeController.cs" company="Lukas Holecy">
//     Copyright (c) Lukas Holecy. All rights reserved.
// </copyright>

namespace Holecy.Services.Controllers;

using Microsoft.AspNetCore.Mvc;

/// <summary>
/// Controller for home page.
/// </summary>
public class HomeController : Controller
{
    /// <summary>
    /// Handles the request for home page.
    /// </summary>
    /// <returns>Home page view.</returns>
    public IActionResult Index()
    {
        return this.View();
    }
}