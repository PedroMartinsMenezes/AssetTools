namespace AssetTool
{
    [JsonAsset("EngineReplicationBridge")]
    public class UEngineReplicationBridge : UObjectReplicationBridge
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}