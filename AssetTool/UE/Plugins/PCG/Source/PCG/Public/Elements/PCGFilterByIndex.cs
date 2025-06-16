namespace AssetTool
{
    [JsonAsset("PCGFilterByIndexSettings")]
    public class UPCGFilterByIndexSettings : UPCGFilterDataBaseSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}