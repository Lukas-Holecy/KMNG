// <copyright file="WeatherForecast.cs" company="Lukas Holecy">
//     Copyright (c) Lukas Holecy. All rights reserved.
// </copyright>

namespace Holecy.Services.Models;

/// <summary>
/// Represents a weather forecast.
/// </summary>
/// <param name="Date">The date of the weather forecast.</param>
/// <param name="TemperatureC">The temperature in Celsius.</param>
/// <param name="Summary">A summary of the weather forecast.</param>
internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    /// <summary>
    /// Gets the temperature in Fahrenheit.
    /// </summary>
    public int TemperatureF => 32 + (int)(this.TemperatureC / 0.5556);
}