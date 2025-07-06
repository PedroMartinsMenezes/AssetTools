namespace AssetTool
{
    [JsonAsset("RemoteControlBinding")]
    public class URemoteControlBinding : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemoteControlLevelIndependantBinding")]
    public class URemoteControlLevelIndependantBinding : URemoteControlBinding
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemoteControlLevelDependantBinding")]
    public class URemoteControlLevelDependantBinding : URemoteControlBinding
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}