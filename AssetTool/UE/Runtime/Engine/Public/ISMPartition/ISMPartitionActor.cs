namespace AssetTool
{
    [JsonAsset("ISMPartitionActor")]
    public class AISMPartitionActor : APartitionActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}