namespace AssetTool
{
    [JsonAsset("PCGWaitSettings")]
    public class UPCGWaitSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}