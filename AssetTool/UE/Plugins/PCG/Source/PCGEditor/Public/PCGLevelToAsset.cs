namespace AssetTool
{
    [JsonAsset("PCGLevelToAsset")]
    public class UPCGLevelToAsset : UPCGAssetExporter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}