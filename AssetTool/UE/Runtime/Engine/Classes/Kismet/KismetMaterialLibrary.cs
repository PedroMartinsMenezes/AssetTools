namespace AssetTool
{
    [JsonAsset("KismetMaterialLibrary")]
    public class UKismetMaterialLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}