namespace AssetTool
{
    [JsonAsset("RemoteControlProtocolDMXSettings")]
    public class URemoteControlProtocolDMXSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}