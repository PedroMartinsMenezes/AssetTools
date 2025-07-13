namespace AssetTool
{
    [JsonAsset("ObjectReplicationBridge")]
    public class UObjectReplicationBridge : UReplicationBridge
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}