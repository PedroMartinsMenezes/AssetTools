namespace AssetTool
{
    [JsonAsset("ReplicationBridge")]
    public class UReplicationBridge : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}