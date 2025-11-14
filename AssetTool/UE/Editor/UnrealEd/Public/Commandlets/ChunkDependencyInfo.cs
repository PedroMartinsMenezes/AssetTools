namespace AssetTool
{
    [JsonAsset("ChunkDependencyInfo")]
    public class UChunkDependencyInfo : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}