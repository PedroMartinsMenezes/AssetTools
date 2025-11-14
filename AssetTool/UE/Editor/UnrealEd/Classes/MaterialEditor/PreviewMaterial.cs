namespace AssetTool
{
    [JsonAsset("PreviewMaterial")]
    public class UPreviewMaterial : UMaterial
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}