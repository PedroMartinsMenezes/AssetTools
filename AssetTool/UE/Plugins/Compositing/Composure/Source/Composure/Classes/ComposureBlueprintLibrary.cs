namespace AssetTool
{
    [JsonAsset("ComposureBlueprintLibrary")]
    public class UComposureBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}