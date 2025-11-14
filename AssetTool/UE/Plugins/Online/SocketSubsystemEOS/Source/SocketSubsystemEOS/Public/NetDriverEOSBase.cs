namespace AssetTool
{
    [JsonAsset("NetDriverEOSBase")]
    public class UNetDriverEOSBase : UIpNetDriver
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}