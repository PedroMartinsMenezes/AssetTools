namespace AssetTool
{
    [JsonAsset("PCGAttributeReduceSettings")]
    public class UPCGAttributeReduceSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}