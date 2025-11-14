namespace AssetTool
{
    [JsonAsset("MassReplicationProcessor")]
    public class UMassReplicationProcessor : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassReplicatorBase")]
    public class UMassReplicatorBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}