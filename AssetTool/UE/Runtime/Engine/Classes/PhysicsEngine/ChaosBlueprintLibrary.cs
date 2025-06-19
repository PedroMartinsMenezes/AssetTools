namespace AssetTool
{
    [JsonAsset("ChaosBlueprintLibrary")]
    public class UChaosBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}