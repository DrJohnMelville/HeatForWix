using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography;
using System.Xml.Linq;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace Melville.HeatForWix;

public class HarvestAssembly: Task
{
    [Required]
    public string Source { get; set; }
    [Required]
    public string IncludeSuffixes { get; set; }
    [Required]
    public string DestName { get; set; }
    [Required]
    [Output]
    public string DestFile { get; set; }

    private static readonly XNamespace ns = "http://wixtoolset.org/schemas/v4/wxs";
    
    public override bool Execute()
    {
       var basepath = Path.GetDirectoryName(BuildEngine9.ProjectFileOfTaskNode);
       var depsPath = PathExpander.Expand(Source, basepath);


       var result = new XElement(ns + "Wix",
           new XElement(ns + "Fragment",
               new XElement(ns + "ComponentGroup",
                   new XAttribute("Id", DestName),
                   new XAttribute("Directory", "INSTALLFOLDER"),
                   AllFiles(Path.GetDirectoryName(depsPath)))));


       File.WriteAllText(DestFile, result.ToString());
       return true;
    }

    private IEnumerable<XElement> AllFiles(string dirName)
    {
        var suffixList = IncludeSuffixes.Split([';'], StringSplitOptions.RemoveEmptyEntries);
        return Directory.EnumerateFiles(dirName)
            .Where(i=>suffixList.Any(j=>i.EndsWith(j, StringComparison.OrdinalIgnoreCase)))
            .Select(WrapFile);
    }

    private XElement WrapFile(string arg)
    {
        return new XElement(ns + "Component",
            new XElement(ns + "File",
                new XAttribute("Source", arg)));
    }
}