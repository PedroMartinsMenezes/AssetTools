namespace AssetTool
{
    [JsonAsset("PickupableStatics")]
    public class UPickupableStatics : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}