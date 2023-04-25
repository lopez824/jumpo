// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Jumpo : ModuleRules
{
	public Jumpo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "EnhancedInput" });
	}
}
