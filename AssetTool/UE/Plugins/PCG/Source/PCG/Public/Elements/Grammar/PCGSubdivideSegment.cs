namespace AssetTool
{
    [JsonAsset("PCGSubdivideSegmentSettings")]
    public class UPCGSubdivideSegmentSettings : UPCGSubdivisionBaseSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}