namespace AssetTool
{
    [JsonAsset("PCGCopyAttributesSettings")]
    public class UPCGCopyAttributesSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}