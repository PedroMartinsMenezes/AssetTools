namespace AssetTool
{
    [JsonAsset("KismetInputLibrary")]
    public class UKismetInputLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}