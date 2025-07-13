namespace AssetTool
{
    [JsonAsset("AnalyticsBlueprintLibrary")]
    public class UAnalyticsBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}