namespace AssetTool
{
    [JsonAsset("PCGFilterByTypeSettings")]
    public class UPCGFilterByTypeSettings : UPCGFilterDataBaseSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}