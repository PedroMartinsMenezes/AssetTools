namespace AssetTool
{
    [JsonAsset("PCGAttributeRemoveDuplicatesSettings")]
    public class UPCGAttributeRemoveDuplicatesSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}