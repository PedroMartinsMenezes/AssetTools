namespace AssetTool
{
    [JsonAsset("LyraListView")]
    public class ULyraListView : UCommonListView
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}