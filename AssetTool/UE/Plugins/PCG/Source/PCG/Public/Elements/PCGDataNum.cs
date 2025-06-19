namespace AssetTool
{
    [JsonAsset("PCGDataNumSettings")]
    public class UPCGDataNumSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}