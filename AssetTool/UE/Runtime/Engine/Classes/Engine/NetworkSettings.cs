namespace AssetTool
{
    [JsonAsset("NetworkSettings")]
    public class UNetworkSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}