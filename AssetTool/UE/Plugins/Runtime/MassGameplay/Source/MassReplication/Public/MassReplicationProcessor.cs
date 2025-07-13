namespace AssetTool
{
    [JsonAsset("MassReplicationProcessor")]
    public class UMassReplicationProcessor : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassReplicatorBase")]
    public class UMassReplicatorBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}