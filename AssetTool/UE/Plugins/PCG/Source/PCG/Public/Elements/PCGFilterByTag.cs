namespace AssetTool
{
    [JsonAsset("PCGFilterByTagSettings")]
    public class UPCGFilterByTagSettings : UPCGFilterDataBaseSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}