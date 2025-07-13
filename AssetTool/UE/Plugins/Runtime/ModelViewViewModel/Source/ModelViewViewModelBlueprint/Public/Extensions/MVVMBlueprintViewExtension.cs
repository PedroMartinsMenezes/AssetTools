namespace AssetTool
{
    [JsonAsset("MVVMBlueprintViewExtension")]
    public class UMVVMBlueprintViewExtension : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}