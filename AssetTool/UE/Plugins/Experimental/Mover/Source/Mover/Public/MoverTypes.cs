namespace AssetTool
{
    [JsonAsset("MoverDataCollectionLibrary")]
    public class UMoverDataCollectionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}