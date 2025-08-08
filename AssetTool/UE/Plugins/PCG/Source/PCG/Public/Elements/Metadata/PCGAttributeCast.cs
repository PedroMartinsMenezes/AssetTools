namespace AssetTool
{
    [JsonAsset("PCGAttributeCastSettings")]
    public class UPCGAttributeCastSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}