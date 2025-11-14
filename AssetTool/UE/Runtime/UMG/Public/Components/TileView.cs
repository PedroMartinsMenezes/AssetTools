namespace AssetTool
{
    [JsonAsset("TileView")]
    public class UTileView : UListView
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}