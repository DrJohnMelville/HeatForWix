using System;
using System.Collections.Generic;

namespace Melville.HeatForWix;

public static class PathExpander
{
    public static string Expand(string path, string basePath)
    {
        var result = new List<string>();
        result.AddRange(SplitIntoComponents(basePath));
        foreach (var component in SplitIntoComponents(path))
        {
            switch (component)
            {
                case ".": break;
                case "..": 
                    result.RemoveAt(result.Count - 1);
                    break;
                default:
                    result.Add(component);
                    break;
            }
        }
        return string.Join("\\", result);
    }

    private static string[] SplitIntoComponents(string basePath) => 
        basePath.Split(['\\','/'], StringSplitOptions.RemoveEmptyEntries);
}