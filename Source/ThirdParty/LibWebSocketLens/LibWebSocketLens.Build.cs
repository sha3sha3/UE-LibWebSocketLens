// Copyright (c) 2022-2023 MrShaaban, Mohamad Shaaban

using System.IO;
using UnrealBuildTool;

public class LibWebSocketLens : ModuleRules
{
	public LibWebSocketLens(ReadOnlyTargetRules Target) : base(Target)
	{
		Type = ModuleType.External;
		if (Target.Platform == UnrealTargetPlatform.HoloLens)
		{

			// Add includes
			PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "include", "Hololens"));

			// Add Libs
			string LibPath = Path.Combine(ModuleDirectory, "lib", "Hololens");

            PublicAdditionalLibraries.Add(Path.Combine(LibPath, "websockets_static.lib"));
        }
		
	}
}
