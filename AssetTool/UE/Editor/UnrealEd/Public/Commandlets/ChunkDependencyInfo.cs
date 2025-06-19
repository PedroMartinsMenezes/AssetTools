namespace AssetTool
{
    [JsonAsset("ChunkDependencyInfo")]
    public class UChunkDependencyInfo : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}