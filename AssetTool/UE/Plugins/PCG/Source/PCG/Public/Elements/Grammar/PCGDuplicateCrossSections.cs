namespace AssetTool
{
    [JsonAsset("PCGDuplicateCrossSectionsSettings")]
    public class UPCGDuplicateCrossSectionsSettings : UPCGSubdivisionBaseSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}