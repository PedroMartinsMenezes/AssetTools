namespace AssetTool
{
    [JsonAsset("PCGAlembicToPCGAssetExporter")]
    public class UPCGAlembicToPCGAssetExporter : UPCGAssetExporter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGLoadAlembicFunctionLibrary")]
    public class UPCGLoadAlembicFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}