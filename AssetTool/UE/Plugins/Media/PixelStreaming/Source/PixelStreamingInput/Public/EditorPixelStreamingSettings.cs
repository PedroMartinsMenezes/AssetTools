namespace AssetTool
{
    [JsonAsset("PixelStreamingSettings")]
    public class UPixelStreamingSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}