namespace AssetTool
{
    [JsonAsset("CommonTreeView")]
    public class UCommonTreeView : UTreeView
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}