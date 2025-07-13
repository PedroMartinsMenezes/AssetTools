namespace AssetTool
{
    [JsonAsset("VPScoutingSubsystemHelpersBase")]
    public class UVPScoutingSubsystemHelpersBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VPScoutingSubsystemGestureManagerBase")]
    public class UVPScoutingSubsystemGestureManagerBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VPScoutingSubsystem")]
    public class UVPScoutingSubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}