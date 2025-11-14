namespace AssetTool
{
    [JsonAsset("MoverDataModelBlueprintLibrary")]
    public class UMoverDataModelBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}