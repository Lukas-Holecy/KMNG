// <copyright file="ApiInfoController.cs" company="Lukas Holecy">
//     Copyright (c) Lukas Holecy. All rights reserved.
// </copyright>

namespace Holecy.Services.Controllers;

using System.Text.Json;
using Holecy.Services.Models;
using Microsoft.AspNetCore.Mvc;

/// <summary>
/// Controller for retrieving information about the API.
/// </summary>
/// <seealso cref="ApiInfo"/>
[ApiController]
[Route("api/[controller]")]
public class ApiInfoController : ControllerBase
{
    private readonly ApiInfo apiInfo;

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiInfoController"/> class.
    /// </summary>
    public ApiInfoController()
    {
        this.apiInfo = new ApiInfo();
    }

    [HttpGet("name")]
    public ActionResult<string> GetName()
    {
        return this.apiInfo.Name;
    }

    /// <summary>
    /// Retrieves the version information of the API.
    /// </summary>
    /// <returns>A string representing the version of the API.</returns>
    [HttpGet("version")]
    public ActionResult<string> GetVersion()
    {
        return this.apiInfo.Version;
    }

    [HttpGet("description")]
    public ActionResult<string> GetDescription()
    {
        return this.apiInfo.Description;
    }

    [HttpGet("assemblyVersion")]
    public ActionResult<string> GetAssemblyVersion()
    {
        return this.apiInfo.AssemblyVersion;
    }

    [HttpGet("allInfo")]
    public ActionResult<string> GetAll()
    {
        return JsonSerializer.Serialize(this.apiInfo);
    }
}