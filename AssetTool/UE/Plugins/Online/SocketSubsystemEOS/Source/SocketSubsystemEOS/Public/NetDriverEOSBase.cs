namespace AssetTool
{
    [JsonAsset("NetDriverEOSBase")]
    public class UNetDriverEOSBase : UIpNetDriver
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}