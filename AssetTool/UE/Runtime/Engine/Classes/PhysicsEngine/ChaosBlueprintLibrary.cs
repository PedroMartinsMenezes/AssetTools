namespace AssetTool
{
    [JsonAsset("ChaosBlueprintLibrary")]
    public class UChaosBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}