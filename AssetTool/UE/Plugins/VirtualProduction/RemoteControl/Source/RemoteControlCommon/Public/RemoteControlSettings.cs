namespace AssetTool
{
    [JsonAsset("RemoteControlSettings")]
    public class URemoteControlSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}