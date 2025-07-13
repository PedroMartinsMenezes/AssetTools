namespace AssetTool
{
    [JsonAsset("MVVMViewListViewBaseClassExtension")]
    public class UMVVMViewListViewBaseClassExtension : UMVVMViewClassExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}