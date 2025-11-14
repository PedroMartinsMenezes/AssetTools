namespace AssetTool
{
    [JsonAsset("PCGLevelToAsset")]
    public class UPCGLevelToAsset : UPCGAssetExporter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}