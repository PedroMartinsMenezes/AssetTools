namespace AssetTool
{
    [JsonAsset("BasicReplicationGraph")]
    public class UBasicReplicationGraph : UReplicationGraph
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}