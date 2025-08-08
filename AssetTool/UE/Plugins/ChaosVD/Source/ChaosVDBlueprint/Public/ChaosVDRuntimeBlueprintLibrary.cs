namespace AssetTool
{
    [JsonAsset("ChaosVDRuntimeBlueprintLibrary")]
    public class UChaosVDRuntimeBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}