namespace AssetTool
{
    [JsonAsset("PCGFilterByTagSettings")]
    public class UPCGFilterByTagSettings : UPCGFilterDataBaseSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}