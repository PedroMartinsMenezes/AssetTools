namespace AssetTool
{
    [JsonAsset("PixelStreamingMediaTexture")]
    public class UPixelStreamingMediaTexture : UTexture2DDynamic
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}