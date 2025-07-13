namespace AssetTool
{
    [JsonAsset("NetObjectBlobHandler")]
    public class UNetObjectBlobHandler : UNetBlobHandler
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}