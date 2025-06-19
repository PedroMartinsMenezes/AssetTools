namespace AssetTool
{
    [JsonAsset("InstancedPlacementPartitionActor")]
    public class AInstancedPlacementPartitionActor : AISMPartitionActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}