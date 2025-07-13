namespace AssetTool
{
    [JsonAsset("GameplayCueFunctionLibrary")]
    public class UGameplayCueFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}