namespace AssetTool
{
    [JsonAsset("MVVMViewModelBase")]
    public class UMVVMViewModelBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}