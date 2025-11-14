namespace AssetTool
{
    [JsonAsset("ComposureBlueprintLibrary")]
    public class UComposureBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}