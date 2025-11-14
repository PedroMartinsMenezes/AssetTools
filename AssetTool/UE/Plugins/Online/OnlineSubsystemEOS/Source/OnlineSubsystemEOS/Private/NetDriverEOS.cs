namespace AssetTool
{
    [JsonAsset("NetDriverEOS")]
    public class UNetDriverEOS : UNetDriverEOSBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}