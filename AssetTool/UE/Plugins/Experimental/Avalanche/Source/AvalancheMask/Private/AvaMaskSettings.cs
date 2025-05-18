namespace AssetTool
{
    [JsonAsset("AvaMaskSettings")]
    public class UAvaMaskSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}