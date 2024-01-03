namespace UnitTests;

public class JsonDepsParserTest
{
    [Fact]
    public void Test1()
    {

    }

    private static string JsonText = """
      {
        "runtimeTarget": {
          "name": ".NETStandard,Version=v2.0/",
          "signature": ""
        },
        "compilationOptions": {},
        "targets": {
          ".NETStandard,Version=v2.0": {},
          ".NETStandard,Version=v2.0/": {
            "Melville.INPC/0.7.1-preview1": {
              "dependencies": {
                "NETStandard.Library": "2.0.3"
              },
              "runtime": {
                "Melville.INPC.dll": {}
              }
            },
            "Microsoft.NETCore.Platforms/1.1.0": {},
            "NETStandard.Library/2.0.3": {
              "dependencies": {
                "Microsoft.NETCore.Platforms": "1.1.0"
              }
            }
          }
        },
        "libraries": {
          "Melville.INPC/0.7.1-preview1": {
            "type": "project",
            "serviceable": false,
            "sha512": ""
          },
          "Microsoft.NETCore.Platforms/1.1.0": {
            "type": "package",
            "serviceable": true,
            "sha512": "sha512-kz0PEW2lhqygehI/d6XsPCQzD7ff7gUJaVGPVETX611eadGsA3A877GdSlU0LRVMCTH/+P3o2iDTak+S08V2+A==",
            "path": "microsoft.netcore.platforms/1.1.0",
            "hashPath": "microsoft.netcore.platforms.1.1.0.nupkg.sha512"
          },
          "NETStandard.Library/2.0.3": {
            "type": "package",
            "serviceable": true,
            "sha512": "sha512-st47PosZSHrjECdjeIzZQbzivYBJFv6P2nv4cj2ypdI204DO+vZ7l5raGMiX4eXMJ53RfOIg+/s4DHVZ54Nu2A==",
            "path": "netstandard.library/2.0.3",
            "hashPath": "netstandard.library.2.0.3.nupkg.sha512"
          }
        }
      }
      """;
}