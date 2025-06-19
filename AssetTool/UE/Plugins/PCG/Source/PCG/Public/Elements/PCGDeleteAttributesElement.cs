namespace AssetTool
{
    [JsonAsset("PCGDeleteAttributesSettings")]
    public class UPCGDeleteAttributesSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}