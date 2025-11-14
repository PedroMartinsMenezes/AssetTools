namespace AssetTool
{
    [JsonAsset("NetObjectBlobHandler")]
    public class UNetObjectBlobHandler : UNetBlobHandler
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}