namespace AssetTool
{
    [JsonAsset("PCGIndirectionSettings")]
    public class UPCGIndirectionSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}