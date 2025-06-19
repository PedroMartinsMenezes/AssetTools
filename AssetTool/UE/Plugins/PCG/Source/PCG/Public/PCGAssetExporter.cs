namespace AssetTool
{
    [JsonAsset("PCGAssetExporter")]
    public class UPCGAssetExporter : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}