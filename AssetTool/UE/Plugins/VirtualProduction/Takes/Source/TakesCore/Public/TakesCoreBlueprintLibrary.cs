namespace AssetTool
{
    [JsonAsset("TakesCoreBlueprintLibrary")]
    public class UTakesCoreBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}