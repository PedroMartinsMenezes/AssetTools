namespace AssetTool
{
    [JsonAsset("KismetMaterialLibrary")]
    public class UKismetMaterialLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}