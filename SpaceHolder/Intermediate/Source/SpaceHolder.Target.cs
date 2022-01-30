using UnrealBuildTool;

public class SpaceHolderTarget : TargetRules
{
	public SpaceHolderTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("SpaceHolder");
	}
}
