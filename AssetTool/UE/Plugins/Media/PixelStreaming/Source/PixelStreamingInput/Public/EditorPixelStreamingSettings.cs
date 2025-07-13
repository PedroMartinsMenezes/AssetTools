namespace AssetTool
{
    [JsonAsset("PixelStreamingSettings")]
    public class UPixelStreamingSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}