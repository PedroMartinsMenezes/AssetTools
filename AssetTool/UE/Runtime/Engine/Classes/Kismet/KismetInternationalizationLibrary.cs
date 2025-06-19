namespace AssetTool
{
    [JsonAsset("KismetInternationalizationLibrary")]
    public class UKismetInternationalizationLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}