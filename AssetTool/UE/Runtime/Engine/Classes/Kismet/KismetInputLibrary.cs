namespace AssetTool
{
    [JsonAsset("KismetInputLibrary")]
    public class UKismetInputLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}