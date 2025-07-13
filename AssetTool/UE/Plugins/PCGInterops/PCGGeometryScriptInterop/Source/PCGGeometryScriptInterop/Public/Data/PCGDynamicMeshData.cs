namespace AssetTool
{
    [JsonAsset("PCGDynamicMeshData")]
    public class UPCGDynamicMeshData : UPCGSpatialData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}