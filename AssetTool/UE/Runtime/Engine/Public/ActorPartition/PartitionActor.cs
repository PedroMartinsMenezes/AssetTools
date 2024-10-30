namespace AssetTool
{
    [JsonAsset("PartitionActor")]
    public class APartitionActor : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}