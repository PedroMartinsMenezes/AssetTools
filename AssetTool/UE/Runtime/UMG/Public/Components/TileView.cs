namespace AssetTool
{
    [JsonAsset("TileView")]
    public class UTileView : UListView
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}