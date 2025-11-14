namespace AssetTool
{
    [JsonAsset("MoverDataCollectionLibrary")]
    public class UMoverDataCollectionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}