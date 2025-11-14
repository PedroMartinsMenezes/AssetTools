namespace AssetTool
{
    [JsonAsset("ReplicationBridge")]
    public class UReplicationBridge : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}