namespace AssetTool
{
    [JsonAsset("PCGSubdivideSegmentSettings")]
    public class UPCGSubdivideSegmentSettings : UPCGSubdivisionBaseSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}