// <copyright file="ApiInfo.cs" company="Lukas Holecy">
//     Copyright (c) Lukas Holecy. All rights reserved.
// </copyright>

namespace Holecy.Services.Models;

using System.Globalization;
using System.Resources;

/// <summary>
/// Represents information about this RestAPI.
/// </summary>
internal sealed class ApiInfo
{
    private static readonly ResourceManager ResourceManager = new("Holecy.Services.Resources.AapiInfoResources", typeof(ApiInfo).Assembly);

    /// <summary>
    /// Gets the name of the rest api.
    /// </summary>
    public static string Name => ResourceManager.GetString("Name", CultureInfo.CurrentCulture)!;

    /// <summary>
    /// Gets the version of the rest api.
    /// </summary>
    public static string Version => "1";

    /// <summary>
    /// Gets the assembly version of the rest api.
    /// </summary>
    public static string AssemblyVersion => typeof(ApiInfo).Assembly.GetName().Version?.ToString()!;

    /// <summary>
    /// Gets the description of the rest api.
    /// </summary>
    public static string Description => ResourceManager.GetString("Description", CultureInfo.CurrentCulture)!;
}