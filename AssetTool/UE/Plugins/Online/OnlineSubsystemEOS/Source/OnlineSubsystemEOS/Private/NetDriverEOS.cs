namespace AssetTool
{
    [JsonAsset("NetDriverEOS")]
    public class UNetDriverEOS : UNetDriverEOSBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}