namespace AssetTool
{
    [JsonAsset("ChaosBlueprintLibrary")]
    public class UChaosBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}