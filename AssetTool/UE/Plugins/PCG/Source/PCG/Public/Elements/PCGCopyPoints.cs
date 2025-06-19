namespace AssetTool
{
    [JsonAsset("PCGCopyPointsSettings")]
    public class UPCGCopyPointsSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}