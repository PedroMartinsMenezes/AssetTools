namespace AssetTool
{
    [JsonAsset("PCGCombinePointsSettings")]
    public class UPCGCombinePointsSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}