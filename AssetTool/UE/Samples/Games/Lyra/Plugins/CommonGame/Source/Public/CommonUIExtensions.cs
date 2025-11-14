namespace AssetTool
{
    [JsonAsset("CommonUIExtensions")]
    public class UCommonUIExtensions : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}