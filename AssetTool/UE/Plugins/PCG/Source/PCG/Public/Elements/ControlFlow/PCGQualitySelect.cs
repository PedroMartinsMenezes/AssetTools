namespace AssetTool
{
    [JsonAsset("PCGQualitySelectSettings")]
    public class UPCGQualitySelectSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}