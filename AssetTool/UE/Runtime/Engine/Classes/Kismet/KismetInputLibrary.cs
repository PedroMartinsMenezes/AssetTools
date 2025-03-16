namespace AssetTool
{
    [JsonAsset("KismetInputLibrary")]
    public class UKismetInputLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}