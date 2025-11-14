namespace AssetTool
{
    [JsonAsset("NavigationDataChunkActor")]
    public class ANavigationDataChunkActor : APartitionActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}