namespace AssetTool
{
    [JsonAsset("PCGFilterByTagSettings")]
    public class UPCGFilterByTagSettings : UPCGFilterDataBaseSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}