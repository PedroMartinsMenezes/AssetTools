namespace AssetTool
{
    [JsonAsset("GameplayCueFunctionLibrary")]
    public class UGameplayCueFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}