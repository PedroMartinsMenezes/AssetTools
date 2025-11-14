namespace AssetTool
{
    [JsonAsset("KismetNodeHelperLibrary")]
    public class UKismetNodeHelperLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}