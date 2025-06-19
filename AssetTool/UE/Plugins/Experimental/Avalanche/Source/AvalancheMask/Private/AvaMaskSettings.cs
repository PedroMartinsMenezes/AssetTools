namespace AssetTool
{
    [JsonAsset("AvaMaskSettings")]
    public class UAvaMaskSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}