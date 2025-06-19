namespace AssetTool
{
    [JsonAsset("MoverDataModelBlueprintLibrary")]
    public class UMoverDataModelBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}