namespace AssetTool
{
    [JsonAsset("TreeView")]
    public class UTreeView : UListView
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}