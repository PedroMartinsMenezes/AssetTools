namespace AssetTool
{
    [JsonAsset("PCGFilterByTagSettings")]
    public class UPCGFilterByTagSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}