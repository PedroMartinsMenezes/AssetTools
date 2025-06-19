namespace AssetTool
{
    [JsonAsset("RecastNavMeshDataChunk")]
    public class URecastNavMeshDataChunk : UNavigationDataChunk
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}