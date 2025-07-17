namespace AssetTool
{
    [JsonAsset("InteractionStatics")]
    public class UInteractionStatics : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}