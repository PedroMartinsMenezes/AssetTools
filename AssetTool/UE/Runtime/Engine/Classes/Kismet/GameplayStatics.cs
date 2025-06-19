namespace AssetTool
{
    [JsonAsset("GameplayStatics")]
    public class UGameplayStatics : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}