namespace AssetTool
{
    [JsonAsset("PCGQualitySelectSettings")]
    public class UPCGQualitySelectSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}