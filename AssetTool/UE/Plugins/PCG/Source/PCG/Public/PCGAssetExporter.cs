namespace AssetTool
{
    [JsonAsset("PCGAssetExporter")]
    public class UPCGAssetExporter : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}