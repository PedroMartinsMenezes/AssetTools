namespace AssetTool
{
    [JsonAsset("PixelStreamingMediaTexture")]
    public class UPixelStreamingMediaTexture : UTexture2DDynamic
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}