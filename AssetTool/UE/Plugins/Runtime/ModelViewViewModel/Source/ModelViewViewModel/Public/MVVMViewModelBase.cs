namespace AssetTool
{
    [JsonAsset("MVVMViewModelBase")]
    public class UMVVMViewModelBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}