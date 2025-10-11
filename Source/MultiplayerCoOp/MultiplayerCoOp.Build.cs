// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MultiplayerCoOp : ModuleRules
{
	public MultiplayerCoOp(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"MultiplayerCoOp",
			"MultiplayerCoOp/Variant_Platforming",
			"MultiplayerCoOp/Variant_Platforming/Animation",
			"MultiplayerCoOp/Variant_Combat",
			"MultiplayerCoOp/Variant_Combat/AI",
			"MultiplayerCoOp/Variant_Combat/Animation",
			"MultiplayerCoOp/Variant_Combat/Gameplay",
			"MultiplayerCoOp/Variant_Combat/Interfaces",
			"MultiplayerCoOp/Variant_Combat/UI",
			"MultiplayerCoOp/Variant_SideScrolling",
			"MultiplayerCoOp/Variant_SideScrolling/AI",
			"MultiplayerCoOp/Variant_SideScrolling/Gameplay",
			"MultiplayerCoOp/Variant_SideScrolling/Interfaces",
			"MultiplayerCoOp/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
