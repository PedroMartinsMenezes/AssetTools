namespace AssetTool
{
    [JsonAsset("TileView")]
    public class UTileView : UListView
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}