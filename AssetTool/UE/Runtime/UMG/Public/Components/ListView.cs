namespace AssetTool
{
    [JsonAsset("ListView")]
    public class UListView : UListViewBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}