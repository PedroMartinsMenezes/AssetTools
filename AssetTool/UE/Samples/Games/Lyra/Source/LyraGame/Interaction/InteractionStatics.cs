namespace AssetTool
{
    [JsonAsset("InteractionStatics")]
    public class UInteractionStatics : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}