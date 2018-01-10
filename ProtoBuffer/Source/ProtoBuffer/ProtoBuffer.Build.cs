// Some copyright should be here...

using UnrealBuildTool;
using System.IO;

public class ProtoBuffer : ModuleRules
{

    private string LibPathR
    {
        get { return Path.GetFullPath(Path.Combine(ModuleDirectory, "../../ThirdParty/lib/Release/libprotobuf.lib")); }
    }
    private string LibPathD
    {
        get { return Path.GetFullPath(Path.Combine(ModuleDirectory, "../../ThirdParty/lib/Debug/libprotobufd.lib")); }
    }
    private string HeadPath
    {
        get { return Path.GetFullPath(Path.Combine(ModuleDirectory, "../../ThirdParty/include")); }
    }

    public ProtoBuffer(TargetInfo Target)
	{
		
		PublicIncludePaths.AddRange(
			new string[] {
				"ProtoBuffer/Public",
                "ProtoBuffer/Proto",
                HeadPath
				// ... add public include paths required here ...
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				"ProtoBuffer/Private",
                 "ProtoBuffer/Proto",
                 HeadPath
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",

				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);

        if (Target.Platform == UnrealTargetPlatform.Win64)
        {
            PublicAdditionalLibraries.Add(LibPathR);
        }
    }
}
