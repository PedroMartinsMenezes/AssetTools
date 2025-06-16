namespace AssetTool
{
    [JsonAsset("PCGLevelToAsset")]
    public class UPCGLevelToAsset : UPCGAssetExporter
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}