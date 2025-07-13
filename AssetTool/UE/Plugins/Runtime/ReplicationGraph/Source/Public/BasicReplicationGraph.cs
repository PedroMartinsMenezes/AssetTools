namespace AssetTool
{
    [JsonAsset("BasicReplicationGraph")]
    public class UBasicReplicationGraph : UReplicationGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}