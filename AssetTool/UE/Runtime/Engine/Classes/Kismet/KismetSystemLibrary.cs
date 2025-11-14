namespace AssetTool
{
    [JsonAsset("KismetSystemLibrary")]
    public class UKismetSystemLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}