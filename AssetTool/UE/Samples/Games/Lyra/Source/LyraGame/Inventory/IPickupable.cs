namespace AssetTool
{
    [JsonAsset("PickupableStatics")]
    public class UPickupableStatics : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}