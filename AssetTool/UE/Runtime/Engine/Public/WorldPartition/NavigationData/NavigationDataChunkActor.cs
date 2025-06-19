namespace AssetTool
{
    [JsonAsset("NavigationDataChunkActor")]
    public class ANavigationDataChunkActor : APartitionActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}