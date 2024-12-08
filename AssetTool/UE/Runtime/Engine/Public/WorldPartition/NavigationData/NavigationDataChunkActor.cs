namespace AssetTool
{
    [JsonAsset("NavigationDataChunkActor")]
    public class ANavigationDataChunkActor : APartitionActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}