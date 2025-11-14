namespace AssetTool
{
    [JsonAsset("WorldPartitionDestructibleHLODComponent")]
    public class UWorldPartitionDestructibleHLODComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WorldPartitionDestructibleHLODMeshComponent")]
    public class UWorldPartitionDestructibleHLODMeshComponent : UWorldPartitionDestructibleHLODComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}