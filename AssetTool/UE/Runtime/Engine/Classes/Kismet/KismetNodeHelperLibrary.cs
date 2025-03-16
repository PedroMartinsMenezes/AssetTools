namespace AssetTool
{
    [JsonAsset("KismetNodeHelperLibrary")]
    public class UKismetNodeHelperLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}