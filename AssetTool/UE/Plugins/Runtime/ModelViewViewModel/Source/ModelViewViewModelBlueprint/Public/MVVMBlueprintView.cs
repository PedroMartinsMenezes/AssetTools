namespace AssetTool
{
    [JsonAsset("MVVMBlueprintViewSettings")]
    public class UMVVMBlueprintViewSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MVVMBlueprintView")]
    public class UMVVMBlueprintView : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}