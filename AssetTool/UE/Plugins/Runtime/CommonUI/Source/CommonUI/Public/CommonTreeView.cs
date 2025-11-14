namespace AssetTool
{
    [JsonAsset("CommonTreeView")]
    public class UCommonTreeView : UTreeView
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}