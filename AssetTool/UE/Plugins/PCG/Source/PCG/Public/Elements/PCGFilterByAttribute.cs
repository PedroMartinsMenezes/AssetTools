namespace AssetTool
{
    [JsonAsset("PCGFilterByAttributeSettings")]
    public class UPCGFilterByAttributeSettings : UPCGFilterDataBaseSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}