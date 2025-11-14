namespace AssetTool
{
    [JsonAsset("PCGCollisionShapeData")]
    public class UPCGCollisionShapeData : UPCGSpatialDataWithPointCache
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
