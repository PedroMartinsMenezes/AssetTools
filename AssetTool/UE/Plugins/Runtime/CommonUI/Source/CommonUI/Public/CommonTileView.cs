namespace AssetTool
{
    [JsonAsset("CommonTileView")]
    public class UCommonTileView : UTileView
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}