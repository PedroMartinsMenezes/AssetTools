namespace AssetTool
{
    [JsonAsset("PCGFilterByTypeSettings")]
    public class UPCGFilterByTypeSettings : UPCGFilterDataBaseSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}