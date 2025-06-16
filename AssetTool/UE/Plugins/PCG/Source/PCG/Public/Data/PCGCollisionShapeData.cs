namespace AssetTool
{
    [JsonAsset("PCGCollisionShapeData")]
    public class UPCGCollisionShapeData : UPCGSpatialDataWithPointCache
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
