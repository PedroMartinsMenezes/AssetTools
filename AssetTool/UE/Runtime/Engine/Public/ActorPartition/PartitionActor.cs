namespace AssetTool
{
    [JsonAsset("PartitionActor")]
    public class APartitionActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}