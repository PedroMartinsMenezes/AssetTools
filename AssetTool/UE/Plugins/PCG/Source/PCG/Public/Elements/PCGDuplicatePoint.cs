namespace AssetTool
{
    [JsonAsset("PCGDuplicatePointSettings")]
    public class UPCGDuplicatePointSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}