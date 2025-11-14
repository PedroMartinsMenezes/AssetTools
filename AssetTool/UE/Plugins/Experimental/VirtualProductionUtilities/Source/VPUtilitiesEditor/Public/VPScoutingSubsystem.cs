namespace AssetTool
{
    [JsonAsset("VPScoutingSubsystemHelpersBase")]
    public class UVPScoutingSubsystemHelpersBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VPScoutingSubsystemGestureManagerBase")]
    public class UVPScoutingSubsystemGestureManagerBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VPScoutingSubsystem")]
    public class UVPScoutingSubsystem : UEditorSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}