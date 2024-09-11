namespace Holecy.Services.Analysis.Models;

using System.Globalization;
using System.Resources;

public class ApiInfo
{
    private static readonly ResourceManager ResourceManager = new ResourceManager("Brochet.Services.Analysis.Resources", typeof(ApiInfo).Assembly);
        
    public string Name => ResourceManager.GetString("Name", CultureInfo.CurrentCulture)!;

    public string Version => "1";

    public string AssemblyVersion => typeof(ApiInfo).Assembly.GetName().Version?.ToString()!;

    public string Description => ResourceManager.GetString("Description", CultureInfo.CurrentCulture)!;
}