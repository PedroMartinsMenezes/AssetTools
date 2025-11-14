namespace AssetTool
{
    [JsonAsset("PCGDataNumSettings")]
    public class UPCGDataNumSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}