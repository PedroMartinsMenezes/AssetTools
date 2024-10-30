namespace AssetTool
{
    [JsonAsset("ChunkDependencyInfo")]
    public class UChunkDependencyInfo : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}