namespace AssetTool
{
    [JsonAsset("PCGAddTagSettings")]
    public class UPCGAddTagSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}