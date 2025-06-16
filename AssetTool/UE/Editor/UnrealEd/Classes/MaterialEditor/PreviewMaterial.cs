namespace AssetTool
{
    [JsonAsset("PreviewMaterial")]
    public class UPreviewMaterial : UMaterial
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}