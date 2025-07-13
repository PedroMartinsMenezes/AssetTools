namespace AssetTool
{
    [JsonAsset("PCGAlembicToPCGAssetExporter")]
    public class UPCGAlembicToPCGAssetExporter : UPCGAssetExporter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGLoadAlembicFunctionLibrary")]
    public class UPCGLoadAlembicFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}