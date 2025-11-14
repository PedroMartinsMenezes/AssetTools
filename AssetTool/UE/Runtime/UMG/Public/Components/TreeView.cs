namespace AssetTool
{
    [JsonAsset("TreeView")]
    public class UTreeView : UListView
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}