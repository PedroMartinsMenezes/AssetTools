namespace AssetTool
{
    [JsonAsset("MassReplicationGridProcessor")]
    public class UMassReplicationGridProcessor : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassReplicationGridRemoverProcessor")]
    public class UMassReplicationGridRemoverProcessor : UMassObserverProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}