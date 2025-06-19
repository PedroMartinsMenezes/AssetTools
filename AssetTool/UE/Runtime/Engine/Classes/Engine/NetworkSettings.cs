namespace AssetTool
{
    [JsonAsset("NetworkSettings")]
    public class UNetworkSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}