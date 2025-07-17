namespace AssetTool
{
    [JsonAsset("CommonUIExtensions")]
    public class UCommonUIExtensions : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}