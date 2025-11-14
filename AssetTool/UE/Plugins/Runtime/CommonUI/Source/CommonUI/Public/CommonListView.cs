namespace AssetTool
{
    [JsonAsset("CommonListView")]
    public class UCommonListView : UListView
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}