namespace AssetTool
{
    [JsonAsset("PCGCollisionShapeData")]
    public class UPCGCollisionShapeData : UPCGSpatialDataWithPointCache
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
