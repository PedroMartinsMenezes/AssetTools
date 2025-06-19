namespace AssetTool
{
    [JsonAsset("PCGFilterByTypeSettings")]
    public class UPCGFilterByTypeSettings : UPCGFilterDataBaseSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}