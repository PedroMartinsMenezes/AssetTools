namespace AssetTool
{
    [JsonAsset("RecastNavMeshDataChunk")]
    public class URecastNavMeshDataChunk : UNavigationDataChunk
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}