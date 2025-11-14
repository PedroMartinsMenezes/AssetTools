namespace AssetTool
{
    [JsonAsset("SpecularProfileRenderer")]
    public class USpecularProfileRenderer : UTextureThumbnailRenderer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}