namespace AssetTool
{
    [JsonAsset("RemoteControlBinding")]
    public class URemoteControlBinding : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemoteControlLevelIndependantBinding")]
    public class URemoteControlLevelIndependantBinding : URemoteControlBinding
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemoteControlLevelDependantBinding")]
    public class URemoteControlLevelDependantBinding : URemoteControlBinding
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}