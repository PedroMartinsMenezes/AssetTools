namespace AssetTool
{
    [JsonAsset("BlueprintThumbnailRenderer")]
    public class UBlueprintThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}