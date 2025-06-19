namespace AssetTool
{
    [JsonAsset("PCGFilterByIndexSettings")]
    public class UPCGFilterByIndexSettings : UPCGFilterDataBaseSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}