namespace AssetTool
{
    [JsonAsset("PCGWaitSettings")]
    public class UPCGWaitSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}