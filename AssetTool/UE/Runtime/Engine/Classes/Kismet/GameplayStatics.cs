namespace AssetTool
{
    [JsonAsset("GameplayStatics")]
    public class UGameplayStatics : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}