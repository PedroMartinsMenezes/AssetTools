namespace AssetTool
{
    [JsonAsset("PCGCollisionWrapperData")]
    public class UPCGCollisionWrapperData : UPCGSpatialData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}