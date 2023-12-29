using Microsoft.Build.Utilities;

namespace Melville.HeatForWix;

public class HarvestAssembly: Task
{
    public override bool Execute()
    {
        Log.LogWarning("John Melville's custom build task is running.");
        return true;
    }
}