namespace AssetTool
{
    [JsonAsset("RemoteControlSettings")]
    public class URemoteControlSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}