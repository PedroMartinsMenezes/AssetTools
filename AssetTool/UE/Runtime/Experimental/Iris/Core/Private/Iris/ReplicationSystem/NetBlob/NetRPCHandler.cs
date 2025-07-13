namespace AssetTool
{
    [JsonAsset("NetRPCHandler")]
    public class UNetRPCHandler : UNetBlobHandler
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}