namespace AssetTool
{
    [JsonAsset("PCGData")]
    public class UPCGData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGDataFunctionLibrary")]
    public class UPCGDataFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}