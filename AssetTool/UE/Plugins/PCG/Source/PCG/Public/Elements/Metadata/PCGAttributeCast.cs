namespace AssetTool
{
    [JsonAsset("PCGAttributeCastSettings")]
    public class UPCGAttributeCastSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}