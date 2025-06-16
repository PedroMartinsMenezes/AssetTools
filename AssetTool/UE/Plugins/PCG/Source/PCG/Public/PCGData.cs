namespace AssetTool
{
    [JsonAsset("PCGData")]
    public class UPCGData : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGDataFunctionLibrary")]
    public class UPCGDataFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}