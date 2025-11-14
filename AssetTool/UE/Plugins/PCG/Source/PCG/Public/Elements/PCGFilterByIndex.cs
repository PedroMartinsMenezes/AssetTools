namespace AssetTool
{
    [JsonAsset("PCGFilterByIndexSettings")]
    public class UPCGFilterByIndexSettings : UPCGFilterDataBaseSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}