// <copyright file="ApiInfoController.cs" company="Lukas Holecy">
//     Copyright (c) Lukas Holecy. All rights reserved.
// </copyright>

namespace Holecy.Services.Controllers;

using System.Text.Json.Nodes;
using Holecy.Services.Models;
using Microsoft.AspNetCore.Mvc;

/// <summary>
/// Controller for retrieving information about the API.
/// </summary>
/// <seealso cref="ApiInfo"/>
[ApiController]
[Route("api/v1/[controller]")]
public class ApiInfoController : ControllerBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiInfoController"/> class.
    /// </summary>
    public ApiInfoController()
    {
    }

    /// <summary>
    /// Gets the name of the API.
    /// </summary>
    /// <returns>The name of the API.</returns>
    [HttpGet("name")]
    public ActionResult<string> GetName()
    {
        return this.Ok(ApiInfo.Name);
    }

    /// <summary>
    /// Retrieves the version information of the API.
    /// </summary>
    /// <returns>A string representing the version of the API.</returns>
    [HttpGet("version")]
    public ActionResult<string> GetVersion()
    {
        return this.Ok(ApiInfo.Version);
    }

    /// <summary>
    /// Gets the description of the API.
    /// </summary>
    /// <returns>The description of the API.</returns>
    [HttpGet("description")]
    public ActionResult<string> GetDescription()
    {
        return this.Ok(ApiInfo.Description);
    }

    /// <summary>
    /// Gets the assembly version of the API.
    /// </summary>
    /// <returns>Version of the API's assembly.</returns>
    [HttpGet("assemblyVersion")]
    public ActionResult<string> GetAssemblyVersion()
    {
        return this.Ok(ApiInfo.AssemblyVersion);
    }

    /// <summary>
    /// Gets all information about the API in a JSON form.
    /// </summary>
    /// <returns>Information about the API in JSON form.</returns>
    [HttpGet("allInfo")]
    public ActionResult<string> GetAll()
    {
        var jsonObject = new JsonObject
        {
            ["Name"] = ApiInfo.Name,
            ["Version"] = ApiInfo.Version,
            ["AssemblyVersion"] = ApiInfo.AssemblyVersion,
            ["Description"] = ApiInfo.Description,
        };

        return this.Ok(jsonObject.ToString());
    }
}