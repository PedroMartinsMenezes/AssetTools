namespace AssetTool
{
    [JsonAsset("PCGCustomHLSLSettings")]
    public class UPCGCustomHLSLSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}