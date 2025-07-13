namespace AssetTool
{
    [JsonAsset("TraceUtilLibrary")]
    public class UTraceUtilLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}