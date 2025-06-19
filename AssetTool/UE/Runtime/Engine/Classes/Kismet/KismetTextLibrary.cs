namespace AssetTool
{
    [JsonAsset("KismetTextLibrary")]
    public class UKismetTextLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}