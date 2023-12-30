using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Melville.HeatForWix;

public class HarvestAssembly: Task
{
    [Required]
    public string Source { get; set; }
    [Required]
    public string Destination { get; set; }
    
    public override bool Execute()
    {
        Log.LogWarning($"From [{Source}] to [{Destination}]");
        return true;
    }
}