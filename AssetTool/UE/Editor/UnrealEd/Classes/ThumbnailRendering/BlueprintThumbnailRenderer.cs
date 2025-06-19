namespace AssetTool
{
    [JsonAsset("BlueprintThumbnailRenderer")]
    public class UBlueprintThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}