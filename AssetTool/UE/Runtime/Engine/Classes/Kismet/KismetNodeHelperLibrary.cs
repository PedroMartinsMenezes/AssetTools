namespace AssetTool
{
    [JsonAsset("KismetNodeHelperLibrary")]
    public class UKismetNodeHelperLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}