namespace AssetTool
{
    [JsonAsset("SpecularProfileRenderer")]
    public class USpecularProfileRenderer : UTextureThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}