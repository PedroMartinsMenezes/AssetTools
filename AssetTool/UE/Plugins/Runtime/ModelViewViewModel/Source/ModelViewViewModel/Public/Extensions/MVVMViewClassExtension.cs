namespace AssetTool
{
    [JsonAsset("MVVMViewExtension")]
    public class UMVVMViewExtension : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MVVMViewClassExtension")]
    public class UMVVMViewClassExtension : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}