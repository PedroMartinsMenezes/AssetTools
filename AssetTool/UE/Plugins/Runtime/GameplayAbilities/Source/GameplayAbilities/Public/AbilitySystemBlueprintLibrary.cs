namespace AssetTool
{
    [JsonAsset("AbilitySystemBlueprintLibrary")]
    public class UAbilitySystemBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}