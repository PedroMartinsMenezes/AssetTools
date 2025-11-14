namespace AssetTool
{
    [JsonAsset("PCGCopyPointsSettings")]
    public class UPCGCopyPointsSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}