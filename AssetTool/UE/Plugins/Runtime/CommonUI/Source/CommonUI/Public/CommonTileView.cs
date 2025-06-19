namespace AssetTool
{
    [JsonAsset("CommonTileView")]
    public class UCommonTileView : UTileView
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}