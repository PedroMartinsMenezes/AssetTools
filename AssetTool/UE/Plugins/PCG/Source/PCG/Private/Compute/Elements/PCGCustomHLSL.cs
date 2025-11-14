namespace AssetTool
{
    [JsonAsset("PCGCustomHLSLSettings")]
    public class UPCGCustomHLSLSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}