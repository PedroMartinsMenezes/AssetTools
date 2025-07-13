namespace AssetTool
{
    [JsonAsset("EngineReplicationBridge")]
    public class UEngineReplicationBridge : UObjectReplicationBridge
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}