namespace AssetTool
{
    [JsonAsset("ClassThumbnailRenderer")]
    public class UClassThumbnailRenderer : UDefaultSizedThumbnailRenderer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}