namespace AssetTool
{
    [JsonAsset("TreeView")]
    public class UTreeView : UListView
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}