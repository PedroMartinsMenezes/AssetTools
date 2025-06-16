namespace AssetTool
{
    [JsonAsset("PCGCollisionWrapperData")]
    public class UPCGCollisionWrapperData : UPCGSpatialData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}