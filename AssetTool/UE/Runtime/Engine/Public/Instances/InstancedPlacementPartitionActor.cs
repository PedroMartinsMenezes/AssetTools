namespace AssetTool
{
    [JsonAsset("InstancedPlacementPartitionActor")]
    public class AInstancedPlacementPartitionActor : AISMPartitionActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}