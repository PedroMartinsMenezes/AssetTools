namespace AssetTool
{
    [JsonAsset("PreviewMaterial")]
    public class UPreviewMaterial : UMaterial
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}