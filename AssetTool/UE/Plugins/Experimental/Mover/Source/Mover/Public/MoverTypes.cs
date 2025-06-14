namespace AssetTool
{
    [JsonAsset("MoverDataCollectionLibrary")]
    public class UMoverDataCollectionLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}