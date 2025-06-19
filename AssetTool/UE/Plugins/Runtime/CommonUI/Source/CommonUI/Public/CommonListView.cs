namespace AssetTool
{
    [JsonAsset("CommonListView")]
    public class UCommonListView : UListView
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}