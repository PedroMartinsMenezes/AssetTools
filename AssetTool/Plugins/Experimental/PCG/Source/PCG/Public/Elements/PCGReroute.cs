namespace AssetTool
{
    [JsonAsset("PCGRerouteSettings")]
    public class UPCGRerouteSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}